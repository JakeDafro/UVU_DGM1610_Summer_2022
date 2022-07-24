using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed;

    public float xRange;

    public Transform blaster;

    public GameObject laser;

    public GameManager gameManager;

    public AudioSource laserBeam;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

   
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

        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false)
        {
            Instantiate(laser, blaster.transform.position, laser.transform.rotation);
            PlayLaserBeam();
        }


        
    }

    public void PlayLaserBeam()
        {
            laserBeam.Play();
        }
    

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}