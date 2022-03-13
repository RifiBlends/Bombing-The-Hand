using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{   
    public Text displayCount;
    public float count = 60f;

    private void Start (){
       
    }
    private void Update (){
        if (count > 0f){
            count -= Time.deltaTime;
            displayCount.text = count.ToString("f0");
        }
    }
    
}