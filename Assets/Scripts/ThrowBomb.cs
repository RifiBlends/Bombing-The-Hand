using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBomb : MonoBehaviour
{
    int xBomb = -5;
    bool player1Play = false;
    bool player2Play = false;

    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    

    public void JogarBomba()
    {
        if(this.transform.position.x < 0)
        {
            player1Play = true;
        }
        if (this.transform.position.x > 0)
        {
            player2Play = true;
        }

        if (player1Play)
        {
            button1.SetActive(true);
            button2.SetActive(false);

            xBomb = 5;

            player1Play = false;
        }
        if (player2Play)
        {
            button1.SetActive(false);
            button2.SetActive(true);

            xBomb = -5;

            player2Play = false;
        }
        //xBomb = xBomb * -1; //Invertendo o valor

        this.transform.position = new Vector3(xBomb, 1, 0);
    }
}
