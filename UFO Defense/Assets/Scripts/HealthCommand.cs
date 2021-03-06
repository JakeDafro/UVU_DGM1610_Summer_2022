using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCommand : MonoBehaviour
{
    public float horizontalInput;

    public float speed;

    public float xRange;

    public Transform blaster;

    public GameObject healthComp;

   
    // Update is called once per frame
    void Update()
    {
        // set horizontalInput to recieve values from keyboard.
        horizontalInput = Input.GetAxis("Horizontal");
        
        //moves player left and right.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //Keeps player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Keeps player in bounds
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(healthComp, blaster.transform.position, healthComp.transform.rotation);
        }

        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    
}