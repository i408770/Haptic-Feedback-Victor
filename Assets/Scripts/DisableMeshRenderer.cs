using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableMeshRenderer : MonoBehaviour
{

    public GameObject rend;
    // Start is called before the first frame update
    void Start()
    {

    }

     public void disablemeshrenderer(){

        rend.SetActive(false);
    }

    public void enablemeshrenderer()
    {
        rend.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
