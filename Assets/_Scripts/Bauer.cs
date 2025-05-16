using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bauer : MonoBehaviour
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
    void top()
    {
            if (y == 1)
            {
                futurePosition.x = x;
                futurePosition.y = y + 2;
                // überprufen ob die Position besetzt ist
                if(ergebnis == false)
                {
                    futurePositionslist.Add(futurePosition);
                }
                
                futurePosition.y = y + 1;
                // überprufen ob die Position besetzt ist
                if(ergebnis == false)
                {
                    futurePositionslist.Add(futurePosition);
                }
            }
            else
            {
                futurePosition.y = y + 1;
                // überprufen ob die Position besetzt ist
                //Überprühen ob auserhalb vom spielfeld
                if(ergebnis == false)
                {
                    futurePositionslist.Add(futurePosition);
                }
            }
            
           
    }
            void topRight()
            {
                futurePosition.x = x + 1;
                futurePosition.y = y + 1;
                // überprufen ob die Position besetzt ist
                if(ergebnis == true)
                {
                    futurePositionslist.Add(futurePosition);
                }
            }

            void topLeft()
            {
                futurePosition.x = x - 1;
                futurePosition.y = y + 1;
                // überprufen ob die Position besetzt ist
                if(ergebnis == true)
                {
                    futurePositionslist.Add(futurePosition);
                }
            }
    
}
