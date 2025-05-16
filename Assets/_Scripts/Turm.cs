using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turm : MonoBehaviour
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
    void TurmS()
    {
            
             for (int i = y + 1; i <=7 ; i++)
            {
                futurePosition.y = i;
                // überprufen ob die Position besetzt ist
                if(false)// position ist nich besetzt 
                {
                    futurePositionslist.Add(futurePosition);
                }
            }

             for (int i = y - 1; i >=0 ; i--)
            {
                futurePosition.y = i;
                // überprufen ob die Position besetzt ist
                if(false)// position ist nich besetzt 
                {
                    futurePositionslist.Add(futurePosition);
                }
            }

            for (int i = x + 1; i <=7 ; i++)
            {
                futurePosition.x = i;
                // überprufen ob die Position besetzt ist
                if(false)// position ist nich besetzt 
                {
                    futurePositionslist.Add(futurePosition);//Liste der Möglichen Positionen
                }
            }

             for (int i = x - 1; i >=0 ; i--)
            {
                futurePosition.x = i;
                // überprufen ob die Position besetzt ist
                if(false)// position ist nich besetzt 
                {
                    futurePositionslist.Add(futurePosition);// Liste der Möglichen Positionen
                }
            }
           
    }
            
  


}
