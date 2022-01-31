using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion : Animals
{
    protected override void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lion")
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
