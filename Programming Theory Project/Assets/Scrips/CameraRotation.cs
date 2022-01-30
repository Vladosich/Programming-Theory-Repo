using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 0.2f;
    [SerializeField] private float timeDelay;
    public float TimeDelay 
    { 
        get 
        {
            return timeDelay;
        } 
        set 
        { 
            if (value < 0) 
            { 
                timeDelay = 0.3f; 
                return; 
            } 
            timeDelay = value; 
        } 
    }
    
    private Vector3 currentRotation;
    private Vector3 cameraRotationAngle = new Vector3 (0, 90, 0);

    void Update()
    {
        timeDelay -= Time.deltaTime;
        Rotation();
    }

    public void Rotation()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(RotationCoordinates(cameraRotationAngle)), rotationSpeed);
    }

    Vector3 RotationCoordinates(Vector3 rotationAngle)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentRotation += rotationAngle;
            TimeDelay = 0.3f;
            return currentRotation;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentRotation -= rotationAngle;
            TimeDelay = 0.3f;
            return currentRotation;
        }
        return currentRotation;
    }

}
