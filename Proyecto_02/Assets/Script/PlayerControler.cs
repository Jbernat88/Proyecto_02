using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horizontalInput;
    public float Speed = 10f;
    public float xRange = 16;
    public GameObject PizzaPrefab;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Speed * Time.deltaTime * horizontalInput);

        //Limite de pantalla derecho
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
        }

        //Limite de posici�n pantalla izquierda
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3 (-xRange, transform.position.y, transform.position.z);
        }

        //Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(PizzaPrefab, transform.position, PizzaPrefab.transform.rotation);
        }

    } 
  
   
}
