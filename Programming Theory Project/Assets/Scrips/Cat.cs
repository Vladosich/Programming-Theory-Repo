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
        else if(other.gameObject.name == "Terrain")
        {

        }
        else
        {
            gameManagerScript.GameOver();
        }
 
    }
}
