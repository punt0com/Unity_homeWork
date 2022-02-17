using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            ChangePlayerScaling(collider);
        }
    }


    void ChangePlayerScaling(Collider collider)
    {
        Debug.Log(collider.transform.localScale.sqrMagnitude);
        Debug.Log(collider.transform.localScale);
        //The length of the vector is square root of(x * x + y * y + z * z)
        if (collider.transform.localScale.sqrMagnitude <= 3)
        {
            collider.transform.localScale = Vector3.one *2;
        }
        else
        {
            collider.transform.localScale = Vector3.one;
        }
    }
}
