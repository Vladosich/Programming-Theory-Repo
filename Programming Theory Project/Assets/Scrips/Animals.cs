using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        
    }
    private void MoveForward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
