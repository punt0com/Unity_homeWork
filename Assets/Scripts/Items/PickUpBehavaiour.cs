using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBehavaiour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.onPowerUpPickUp += PowerUpGotten;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GameManager.instance.PowerUpPickUp("pito");
        }
    }

    private void PowerUpGotten(string gameObject)
    {
        Debug.Log(gameObject);
        GameManager.instance.PowerUpPickUp(gameObject);
    }

}
