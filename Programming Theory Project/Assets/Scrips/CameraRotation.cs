using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 0.2f;

    [SerializeField] Vector3 currentRotation;
    Vector3 cameraRotationAngle = new Vector3 (0, 90, 0);

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(Rotation(cameraRotationAngle)), rotationSpeed);
    }

    Vector3 Rotation(Vector3 rotationAngle)
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentRotation += rotationAngle;
            return currentRotation;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentRotation -= rotationAngle;
            return currentRotation;
        }
        return currentRotation;
    }
}
