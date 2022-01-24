using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion : Animals
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Lion")
        {
            UpdateScore();
        }
        else
        {
            Debug.Log("u lose");
        }

    }
}
