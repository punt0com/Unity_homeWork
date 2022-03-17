using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 direction = new Vector3();
    [SerializeField] float speed = 3f;
    //[SerializeField] float damage = 5f;
    void Start()
    {
        //InvokeRepeating
        Invoke("DestroyBullet", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        Move(direction);
    }

    private void Move(Vector3 direction)
    {

        transform.Translate((Vector3.back * 3)* Time.deltaTime * speed);
    }

    void DestroyBullet()
    {

        Destroy(gameObject);

        //this.bullet.SetActive(false);
    }
}
