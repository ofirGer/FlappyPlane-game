using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
     public float playerSpeed = 15f
        ;
    public float rotationSpeed;
    public float verticalInput;
    public GameObject mainCamera;
    public GameObject hoodCamera;

    

   


    // Start is called before the first frame update
    private void Update()
    {
        // switch between main camera and first person camera
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCamera.SetActive(!mainCamera.activeInHierarchy);
            hoodCamera.SetActive(!hoodCamera.activeInHierarchy);
        }
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed );

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        
        
    }
}
