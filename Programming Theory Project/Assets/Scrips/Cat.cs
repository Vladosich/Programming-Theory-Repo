using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animals
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Cat")
        {
            UpdateScore();
        }
        else
        {
            Debug.Log("u lose");
        }
 
    }
}
