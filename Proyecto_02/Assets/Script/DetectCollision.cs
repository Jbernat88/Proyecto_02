using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherColllider)
    {
        //Destruye el proyectil
        Destroy(gameObject);

        //Destruye el animal
        Destroy(otherColllider.gameObject);
    }

}
