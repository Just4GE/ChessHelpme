using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leufer : MonoBehaviour
{

    public Controller trackpos;
    public List<Vector2> futurePositionslist;
    int x = 0;
    int y=  0;
    bool ergebnis = false;
    Vector2 futurePosition;
    // Start is called before the first frame update
    void Start()
    {
        futurePosition = new Vector2();
        futurePositionslist = new List<Vector2>();
       
    }
    // Start is called before the first frame update
     void TurmS()
    {       
             for (int i = 1; i <= 7 ; i++)
            {
                int newX = position.x;
                int newY = position.y;
                //Prüfen ob die Position besetzt ist
                if( IsValidMove(new Vector2Int(newX + i && newY + i))
                {
                    // Prüfe ob die Position noch im feld
                    if (futurePosition.x + i && futurePosition.y + i)  
                    {
                        newX = ++i;
                        newY = ++i;
                        viableMoves.Add(new Vector2Int(newX,newY));
                    }  
                }
                //Prüfen ob die Position besetzt ist
                if(IsValidMove(new Vector2Int(newX - i && newY - i))
                {
                    // Prüfe ob die Position noch im feld
                    if (IsValidMove(new Vector2Int(newX - i && newY - i))  
                    {
                        newX = --i;
                        newY = --i;
                        viableMoves.Add(new Vector2Int(newX,newY));
                    }  
                }


                //Prüfen ob die Position besetzt ist
                if(IsValidMove(new Vector2Int(NewX- i && NewY + i))
                {
                    // Prüfe ob die Position noch im feld
                    if (IsValidMove(new Vector2Int(NewX- i && NewY + i))  
                    {
                        newX = --i;
                        newY = ++i;
                        viableMoves.Add(new Vector2Int(newX,newY));
                    }  
                }

                //Prüfen ob die Position besetzt ist
                if(IsValidMove(new Vector2Int(NewX + i && NewY - i))
                {
                    // Prüfe ob die Position noch im feld
                    if (IsValidMove(new Vector2Int(NewX + i && NewY - i))  
                    {
                        newX = ++i;
                        newY = --i;
                        viableMoves.Add(new Vector2Int(newX,newY));
                    }  
                }


            }

           
           
    }
}
