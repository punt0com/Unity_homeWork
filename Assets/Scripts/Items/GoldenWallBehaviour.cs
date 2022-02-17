using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenWallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    float time = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionStay(Collision collision)
    {
        
        time += Time.deltaTime;
        Debug.Log(time);
        if (time > 2f)
        {
            collision.transform.transform.position = new Vector3(Random.Range(0f, 10f), Random.Range(0f, 10f), Random.Range(0f, 10f));
            time = 0;
        }
    }
}
