using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float playerSpeed = 1.5f;
    [SerializeField] 
    float cameraAxisX = 0f;
    float cameraAxisY = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayerToLocation();
        RotatePlayer();
        Jump();

    }

    private void FixedUpdate()
    {
        
    }

    void MovePlayerToLocation(){
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

    }
    // hay equivalentes en collider
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log( "estas chocando con el objeto: "+ collision.gameObject.tag); 
        if(collision.transform.tag == "Portal")
        {
            Debug.Log("Y este componente cambia de tamanio");
        }
    }

    private void OnGameOver()
    {
        SceneManager.LoadScene("SampleScene");
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("estas chocando con el objeto: " + collider.gameObject.tag);
        if (collider.transform.tag == "Portal")
        {
            Debug.Log("Y este componente cambia de tamanio");
        }
    }
    void RotatePlayer()
    {

        cameraAxisX += Input.GetAxis("Mouse X");
        cameraAxisY += Input.GetAxis("Mouse Y");
        Quaternion quaternion = Quaternion.Euler(0, cameraAxisX, cameraAxisY);
        transform.localRotation = quaternion;
    }

    void PlayerInput(Vector3 movement)
    {
        transform.Translate(movement * Time.deltaTime * playerSpeed);

    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            PlayerInput(Vector3.up * 3);
        }
    }
}

