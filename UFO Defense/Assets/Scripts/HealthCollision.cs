using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        
    }
}