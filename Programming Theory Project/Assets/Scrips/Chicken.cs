using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animals
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Chicken")
        {
            UpdateScore();
        }
        else
        {
            Debug.Log("u lose");
        }

    }
}
