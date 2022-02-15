using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Vector3 direction = new Vector3();
    [SerializeField] float speed = 3f;
    //[SerializeField] float damage = 5f;
    void Start()
    {
        //InvokeRepeating
        Invoke("DestroyBullet", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        Move(direction);
    }

    private void Move(Vector3 direction)
    {

        transform.Translate(direction * Time.deltaTime * speed);
    }

    void DestroyBullet()
    {

        Destroy(gameObject);

        //this.bullet.SetActive(false);
    }
}
