using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    Vector3 playerPosition;
    float lookSpeed = 3f;
    float enemySpeed = 1.5f;
    //[SerializeField] float speed =2f;
    enum behaviours { look, lookLerp, follow }
    [SerializeField] behaviours behaviour;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (behaviour)
        {
            case behaviours.follow:
                FollowPlayer();
                break;
            case behaviours.look:
                LookAt();
                break;
            case behaviours.lookLerp:
                LookAtLerp();
                break;
          
            default:
                FollowPlayer();
                break;
        }

    }

    void LookAt()
    {
        transform.LookAt(player);
    }

    void LookAtLerp()
    {
        Quaternion rotation = Quaternion.LookRotation(player.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation,rotation,Time.deltaTime * lookSpeed);
    }

    void FollowPlayer()
    {

        var distance = Vector3.Distance(transform.position, player.position);
        if (distance > 2)
        {
            transform.position = Vector3.MoveTowards(transform.position, (player.position), 1.5f * Time.deltaTime);
        }
        
        LookAtLerp();
    }
}
