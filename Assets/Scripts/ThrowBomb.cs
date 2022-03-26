using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBomb : MonoBehaviour
{
    int xBomb;
    [SerializeField] bool canP1 = false;
    [SerializeField] bool canP2 = false;

    [SerializeField] GameObject button1;
    [SerializeField] GameObject button2;
    

    [SerializeField] GameManager gameManager;

    private void Start()
    {
        PosicaoStartAleatorio();
    }

    private void Update()
    {
        CheckBombPosition();
    }

    void CheckBombPosition()
    {
        if (this.transform.position.x < 0)
        {
            canP1 = true;
            button1.gameObject.SetActive(true);

            canP2 = false;
            button2.gameObject.SetActive(false);
        }
        if (this.transform.position.x > 0)
        {
            canP2 = true;
            button2.gameObject.SetActive(true);

            canP1 = false;
            button1.gameObject.SetActive(false);
        }
    }

    public void CheckPlay()
    {
        if (canP1)
        {
            TranslateBomb(5);
            canP1 = false;
        }

        if (canP2)
        {
            TranslateBomb(-5);
            canP2 = false;
        }
    }

    public void TranslateBomb(int b)
    {
        this.transform.position = new Vector3(b, 1, 0);
    }

    public void PosicaoStartAleatorio()
    {
        int posStart = Random.Range(-5, 5);

        if (posStart < 0) //Vulgo lado esquerdo
        {
            xBomb = -5;
            PlayerController.canP1 = true;
            button1.gameObject.SetActive(true);
        }
        if(posStart > 0) //Vulgo lado direito
        {
            xBomb = 5;
            PlayerController.canP2 = true;
            button2.gameObject.SetActive(true);
        }
        if(posStart == 0)
        {
            PosicaoStartAleatorio();
        }

        this.transform.position = new Vector3(xBomb, 1, 0);
    }

    public void EssaProvaVaiSerUmEstouro()
    {
        int player = 0;

        //Checar a posição da bomba
        if (this.transform.position.x == 5)
            player = 2;
        if (this.transform.position.x == -5)
            player = 1;

        //Chama uma animação
        
        //Tira um de vida do perdedor (Função decrementar vida)
        gameManager.DecrementaVida(player);
    }
}
