using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animals
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Cat")
        {
            gameManagerScript.UpdateScore();
        }
        else
        {
            gameManagerScript.GameOver();
        }
 
    }
}
