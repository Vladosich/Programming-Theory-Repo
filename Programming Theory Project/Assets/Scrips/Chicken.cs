using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animals
{
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Chicken")
        {
            gameManagerScript.UpdateScore();
        }
        else if (other.gameObject.name == "Terrain")
        {

        }
        else
        {
            gameManagerScript.GameOver();
        }

    }
}
