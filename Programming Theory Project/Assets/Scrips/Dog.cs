using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animals
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Dog")
        {
            UpdateScore();
        }
        else
        {
            Debug.Log("u lose");
        }

    }
}
