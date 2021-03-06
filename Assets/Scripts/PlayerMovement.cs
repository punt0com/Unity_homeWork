using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float playerSpeed = 1.5f;

    float cameraAxisX = 0f;
    float cameraAxisY = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        if (Input.GetKey(KeyCode.W))
        {
            PlayerInput(Vector3.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerInput(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerInput(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerInput(Vector3.back);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            PlayerInput(Vector3.up*3);
        }
        
            
        



    }
    void PlayerInput(Vector3 movement)
    {
        transform.Translate(movement * Time.deltaTime * playerSpeed);

    }

    void RotatePlayer()
    {
        
        cameraAxisX += Input.GetAxis("Mouse X");
        cameraAxisY += Input.GetAxis("Mouse Y");

        Quaternion quaternion = Quaternion.Euler(0,cameraAxisX, cameraAxisY);
        transform.localRotation = quaternion;
    }
}

