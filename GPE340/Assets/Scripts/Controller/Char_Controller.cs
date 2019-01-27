using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Controller : MonoBehaviour
{
    public Pawn pawn;

    void Start()
    {

    }

    void Update()
    {
        //calls each block(function)
        Rotate();
        Move();

    }
    void Rotate()
    {
        // Create a Plane object
        Plane thePlane = new Plane(Vector3.up, pawn.tf.position);
        // Racyast out the camera 
        float distance;
        Ray theRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        thePlane.Raycast(theRay, out distance);
        // find point on ray 
        Vector3 targetPoint = Camera.main.ScreenPointToRay(Input.mousePosition).GetPoint(distance);
        // Rotates towards thepoint
        pawn.RotateTowards(targetPoint);
    }

    void Move()
    {
        // Move
        Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        moveDirection = Vector3.ClampMagnitude(moveDirection, 1.0f);
        moveDirection = pawn.tf.InverseTransformDirection(moveDirection);

        pawn.move(moveDirection);
    }

}
