using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperlim = 30f;
    private float lowerlim = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Bala Fallida
        if(transform.position.z > upperlim)
        {
            Destroy(gameObject);
        }

        //Animal que llega al limite inferior
        if(transform.position.z < lowerlim)
        {
            Destroy(gameObject);
        }

    }
}
