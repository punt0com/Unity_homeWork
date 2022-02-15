using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Vector3 direction = new Vector3(0f, 0f, 0f);
    //[SerializeField] float damage = 5f;
    //[SerializeField] float afterBtn = 0;
    //[SerializeField] float delay = 2f;
    //[SerializeField] float destroyDelay = 2f;
    [SerializeField] GameObject bullet;
    
    GameObject instanciatedbullet;

    
    void Start()
    {
        //InvokeRepeating("SpawnBullet", afterBtn, delay);

        //InvokeRepeating("DestroyBullet", afterBtn, destroyDelay);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnBullet();
        }

    }

   

    void DuplicateBulletScale()
    {
        if (instanciatedbullet.transform.localScale.x >= 2.0f)
        {
            instanciatedbullet.transform.localScale = (transform.localScale / 2);
        }
        else
        {
            instanciatedbullet.transform.localScale = (transform.localScale * 2);
        }

    }
   

    void SpawnBullet()
    {

        //entiendo que quaternion es para angulos, la verdad es que no le se solo agarre el ejemplo de la documentacion oficial de unity y sin el quaternion el insetar un Vector3 no funciona
        instanciatedbullet = Instantiate(bullet, transform);


    }



}

