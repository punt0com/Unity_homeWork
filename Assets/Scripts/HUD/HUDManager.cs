using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] private Text[] allGems = new Text[2];
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetGemCount();
    }

    void GetGemCount()
    {
        int[] gems = GameManager.instance.gems;
        for (int i = 0; i < gems.Length; i++)
        {
            allGems[i].text =  "x" + gems[i];
        }
    }
}
