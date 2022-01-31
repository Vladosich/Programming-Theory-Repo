using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    private float moveSpeed = 10f;
    private bool isMoving;
    

    public GameManager gameManagerScript;
    public CameraRotation cameraRotationScript;
    
    
    private void Start()
    {
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
        cameraRotationScript = GameObject.Find("Main Camera").GetComponent<CameraRotation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cameraRotationScript.TimeDelay < 0) 
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
    
    private void LookAtCameraDirection()
    {
        transform.rotation = Camera.main.transform.rotation;
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Terrain")
        {

        }
        else
        {
            gameManagerScript.GameOver();
        }
    }



}
