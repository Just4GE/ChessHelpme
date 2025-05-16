using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class König : MonoBehaviour
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

    // Update is called once per frame
    void KönigS()
    {
        futurePosition.x = x;
        futurePosition.y = y;
            
        for (int i = -1; i < 1; i++)
        {
            futurePosition.x = i;
            for (int j = -1; j < 1; j++)
            {
                futurePosition.y = j;

                if(IsValidMove(Pos))//position auser halb
                {
                    if ()//position schon besetzt
                    {
                        IsviableMoves.Add(Pos));
                    }
                }
            }
        }
           
    }
}
