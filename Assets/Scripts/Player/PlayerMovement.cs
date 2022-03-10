using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    float playerSpeed = 5f;
    float cameraAxisX = 0f;
    float cameraAxisY = 0f;
    //float moveHorizontal = 0f;
    //float moveVertical = 0f;
    bool canJump = false;

    List<string> ItemList = new List<string>();

    Dictionary<string, GameObject> powerUps = new Dictionary<string, GameObject>();

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

    void MovePlayerToLocation()
    {


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
        //Debug.Log("estas chocando con el objeto: " + collision.gameObject.tag);
        if (collision.transform.tag == "Floor")
        {
            canJump = true;
        }
        if (collision.transform.tag == "Item")
        {
            ItemList.Add(collision.gameObject.tag);
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log(collision);
        canJump = false;
    }



    void PlayerInput(Vector3 movement)
    {
        //transform.Translate(movement * Time.deltaTime * playerSpeed, Space.World);
        transform.Translate(movement * Time.deltaTime * playerSpeed);


        //ayuda con esta parte que no se girar hacia la dirrecion correcta 
        //moveHorizontal = Input.GetAxis("Horizontal");
        //moveVertical = Input.GetAxis("Vertical");
        //Vector3 rotation = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //rotation.Normalize();

        //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.75F);
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && canJump == true)
        {
            transform.Translate((Vector3.up * 3) * Time.deltaTime * playerSpeed);

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
        if (collider.transform.tag == "PowerUp")
        {
            if (powerUps.ContainsKey("start"))
            {
                playerSpeed = 5;
            }
            else
            {
                powerUps.Add("star", collider.gameObject);
                playerSpeed += 3;
            }

        }

    }
    void RotatePlayer()
    {

        cameraAxisX += Input.GetAxis("Mouse X");
        cameraAxisY += Input.GetAxis("Mouse Y");
        Quaternion quaternion = Quaternion.Euler(0, cameraAxisX, cameraAxisY);
        transform.localRotation = quaternion;
    }


}

