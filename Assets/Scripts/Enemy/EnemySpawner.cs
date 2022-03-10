using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] enemies = new GameObject[5];

    void Start()
    {
        Invoke("firtToLast", 1f);

        Invoke("lastToFirst", 10f);
    }

    // Update is called once per frame
    void Update()
    {



    }


    IEnumerator firtToLast()
    {
        WaitForSeconds wait = new WaitForSeconds(2f);
        for (int i = 0; i < enemies.Length; i++)
        {

            Instantiate(enemies[i], transform);
            yield return wait;
        }
    }
    void lastToFirst()
    {
        for (int i = enemies.Length; i > enemies.Length; i--)
        {
            Instantiate(enemies[i], transform);
        }

    }
}
