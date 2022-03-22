using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingDoorBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.onNearDoorTriggerEnter += onDoorOpen;
        GameManager.instance.onNearDoorTriggerExit += onDoorClose;
    }

    public void onDoorOpen()
    {
        transform.position = new Vector3(transform.position.x, 5.0f, transform.position.z);
    }


    public void onDoorClose()
    {
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
    }

}
