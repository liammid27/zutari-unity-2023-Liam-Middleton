using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    //Variables needed for movement
    public float speed;
    private Rigidbody rb;
    private Renderer ren;
    public Slider slider;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ren = GetComponent<Renderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //Getting float variables for movement 
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        //Making the speed of the cube equal to the value of the velocity slider

        speed = slider.GetComponent<Slider>().value;

        //Applying vector 3 force to move cube rigidbody
        Vector3 moveVect = new Vector3(horizontal, vertical, 0);
        rb.MovePosition(transform.position + moveVect * Time.deltaTime * speed);

        //Changes cube colour based on the keyboard inputs (the direction its moving)
        if (Input.GetKeyDown(KeyCode.W))
        {
            ren.material.color = Color.blue;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            ren.material.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            ren.material.color = Color.green;
        }
        else if(Input.GetKeyDown(KeyCode.A)) 
        {
            ren.material.color = Color.yellow;
        }

        //Flips cube in y direction (vertical) when going off screen
        if(this.transform.position.y > 5)
        {
            this.transform.position = new Vector3(transform.position.x, -5, transform.position.z);
        }
        else if(this.transform.position.y < -5)
        {
            this.transform.position = new Vector3(transform.position.x, 5, transform.position.z);
        }

        //Flips cube in x direction (horizontal) when going off screen
        if (this.transform.position.x > 9)
        {
            this.transform.position = new Vector3(-9, transform.position.y, transform.position.z);
        }
        else if (this.transform.position.x < -9)
        {
            this.transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }
    }

}

