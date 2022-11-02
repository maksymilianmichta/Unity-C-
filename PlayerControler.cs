using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] float torque = 1f ;
    [SerializeField] float boostSpeed = 25f ;
    [SerializeField] float baseSpeed = 15f ;
    [SerializeField] float boostTime = 1.5f;

    Rigidbody2D rbd2;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;


    // Start is called before the first frame update
    void Start()
        {
            rbd2 = GetComponent<Rigidbody2D>();
            surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
        }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
        RotatePlayer();
        Boost();
        }
        

    }

    public void NoControl()
    {
        canMove = false;
    }

    void Boost()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            surfaceEffector2D.speed = boostSpeed ;
            
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed ;
            
        }



    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rbd2.AddTorque(torque);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rbd2.AddTorque(-torque);
        }
    }
}
