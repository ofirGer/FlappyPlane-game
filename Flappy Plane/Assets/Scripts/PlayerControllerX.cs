using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Range(0, 30)] public float playerSpeed = 15f;

    [SerializeField] float rotationSpeed;
    [SerializeField] float verticalInput;
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject hoodCamera;


    private void Update()
    {
        // switch between main camera and first person camera
        SwitchCameras();
    }

    private void SwitchCameras()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCamera.SetActive(!mainCamera.activeInHierarchy);
            hoodCamera.SetActive(!hoodCamera.activeInHierarchy);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }

    private void MovePlayer()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed);
    }

    
}
