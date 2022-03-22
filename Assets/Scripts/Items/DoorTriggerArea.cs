using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerArea : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        GameManager.instance.DoorTriggerEnter();
    }

    private void OnTriggerExit(Collider other)
    {
       
        GameManager.instance.DoorTriggerExit();
    }
}
