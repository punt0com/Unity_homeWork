using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    

    // Start is called before the first frame update

    private void Awake()
    {
        int countAM = FindObjectsOfType<AudioManager>().Length;

        if (countAM > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }

    }
 
}
