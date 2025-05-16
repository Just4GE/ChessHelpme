using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public List<Vector2> piecePositions;
    public GameObject chessContainer;

    void Start()
    {
        piecePositions = new List<Vector2>();
    }

    public void UpdatePiecePosition()
    {
        RemoveOldPositions();
        for (int i = 0; i < chessContainer.transform.childCount; i++){
        Transform chessPiece = chessContainer.transform.GetChild(i);

        // Abrufen des ChessPiece-Scripts
        Tile chessPieceScript = chessPiece.GetComponent<Tile>();

        // Position des Schachstücks aus dem Script abrufen
        Vector2 chessPiecePosition = chessPieceScript.Position;

        // Speichern der Position des Schachstücks
        piecePositions.Add(chessPiecePosition);
        }     
    }

    private void RemoveOldPositions()
    {
        piecePositions.Clear();
    }
}

