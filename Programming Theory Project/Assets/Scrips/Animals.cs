using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    private float moveSpeed = 10f;
    private bool isMoving;

    public GameManager gameManagerScript;
    public GameObject gameManager;
    
    
    private void Start()
    {
        gameManager = GameObject.Find("GameManager");
        gameManagerScript = gameManager.GetComponent<GameManager>();
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
    
    protected void UpdateScore()
    {
        gameManagerScript.score++;
        gameManagerScript.scoreText.text = "Score: " + gameManagerScript.score;
    }

}
