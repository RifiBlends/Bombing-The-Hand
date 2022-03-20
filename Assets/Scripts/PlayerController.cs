using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static bool canP1, canP2 = false;
    [SerializeField] Transform bomb;

    void OnTriggerEnter(Collider other)
    {
        if(bomb.position.x < 0)
        {
            canP1 = true;
            print("Colidi com o lado esquerdo");
        }
        if(bomb.position.x > 0)
        {
            canP2 = true;
            print("Colidi com o lado direito");
        }
    }
}
