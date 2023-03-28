using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    //Variables needed for movement
    public float speed = 5f;
    private Rigidbody rb;
    private Renderer ren;

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

        //Applying vector 3 force to move cube rigidbody
        Vector3 moveVect = new Vector3(horizontal, vertical, 0);
        rb.MovePosition(transform.position + moveVect * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.W))
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
    }

}

