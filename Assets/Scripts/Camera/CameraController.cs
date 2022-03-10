using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    //first person view
    [SerializeField] GameObject fpv;
    bool fpvActive = true;
    [SerializeField] GameObject topDownView;
    bool topDownViewActive = false;
    void Start()
    {
        fpv.SetActive(fpvActive);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            fpvActive = !fpvActive;
            fpv.SetActive(fpvActive);

            topDownViewActive = !topDownViewActive;
            topDownView.SetActive(topDownViewActive);
        }
        
    }
}
