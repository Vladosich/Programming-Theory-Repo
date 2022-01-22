using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    float moveSpeed = 10f;
    bool isMoving;
    
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            isMoving = true;
        }
        if (isMoving)
        {
            MoveForward();
        }
        else
        {
            LookAtCameraDirection();
        }
        
    }
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    
    void LookAtCameraDirection()
    {
        transform.rotation = Camera.main.transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Cat")
        {
            Debug.Log("!!!");
        }
    }
}
