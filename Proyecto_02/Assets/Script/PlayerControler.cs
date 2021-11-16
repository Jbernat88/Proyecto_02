using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horizontalInput;
    public float Speed = 10f;
    public float xRange = 16;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Speed * Time.deltaTime * horizontalInput);


        if (transform.position.x > xRange)
        {
            transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
        }

    } 
  
   
}
