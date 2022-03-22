using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager instance;
    public enum gemType { Red, Yellow }
    public int[] gems;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            gems = new int[Enum.GetNames(typeof(gemType)).Length];
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public event Action onNearDoorTriggerEnter;
    public void DoorTriggerEnter()
    {
        onNearDoorTriggerEnter();
    }


    public event Action onNearDoorTriggerExit;
    public void DoorTriggerExit()
    {
        onNearDoorTriggerExit();
    }

    public event Action<string> onPowerUpPickUp;
    public void PowerUpPickUp(string test)
    {
        onPowerUpPickUp(test);
    }
}
