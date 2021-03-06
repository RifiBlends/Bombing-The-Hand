using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{   
    [SerializeField] private Slider slider;
    public Text displayCount;
    public float count = 10f;

    [SerializeField] ThrowBomb throwBomb;

    private void Start (){
       
    }
    private void Update (){
        //sliderValor = slider.value*100;

        if (count <= 0)//Chamo a fun??o de estourar a bomba
            throwBomb.EssaProvaVaiSerUmEstouro();

        if (count > 0f)
        {           
            count -= Time.deltaTime;
            AtualizaSlider(count);            
        }
    }

    void AtualizaSlider (float atualiza){
        atualiza = atualiza / 100;
        slider.value = atualiza;
    }
    
    public void ZeraTimer()
    {
        count = 10f;
    }
}