using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text gameOverTxt;
    [SerializeField] int p1HP, p2HP;
    [SerializeField] ThrowBomb throwBomb;
    [SerializeField] Timer timer;


    void Start()
    {
        p1HP = 3;
        p2HP = 3;

        //GameOver();
    }

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Pause() //Input na HUD para pausar o jogo
    {
        
            Time.timeScale = 0;
         
    }

    public void Restart() //Input na HUD para resetar o jogo
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver(int player) //Chamar alguma HUD
    { 
        if(player == 1)
            gameOverTxt.text = "Jogador 2 Venceu";

        if (player == 2)
            gameOverTxt.text = "Jogador 1 Venceu";

        Pause();
    }

    public void DecrementaVida(int player) //Checar se chegou a 0:(Funcao GameOver) se não: Chama a proxima rodada      
    {
        if (p1HP == 0 || p2HP == 0)
        {
            GameOver(player);
            return;
        }
        
        NextRound(player);
        
        if (player == 1)
        {
            p1HP--;
            print("P1 HP " + p1HP);
            //AtualizaHUD
        }


        if (player == 2)
        {
            p2HP--;
            print("P2 HP " + p2HP);
            //AtualizaHUD
        }        
    }

    void NextRound(int player)//Chama proxima rodada
    {
        //Reseta timer
        timer.ZeraTimer();
        throwBomb.PosicaoStartAleatorio();
    }
}
