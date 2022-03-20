using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{   
    [SerializeField] private Slider slider;
    float sliderValor;
    float fillSpeed = 0.1f;
    public Text displayCount;
    public float count = 60f;

    private void Start (){
       
    }
    private void Update (){
        //sliderValor = slider.value*100;
        if (count > 0f){
            count -= Time.deltaTime;
            AtualizaSlider (count);
        }

        if (Input.GetKeyDown("r")) // reseta a cena - debug
        {
            SceneManager.LoadScene(0);
        }
    }

    void AtualizaSlider (float atualiza){
        atualiza = atualiza / 100;
        slider.value = atualiza;
    }
    
}