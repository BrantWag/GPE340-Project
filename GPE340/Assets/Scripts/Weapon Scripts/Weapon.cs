using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{  // Weapon Vairables
    public Transform RHPoint;
    public Transform LHPoint;
    public Transform shotSpawn;

    // Shooting variables
    public float shootSpeed;
    public GameObject bullet;

    void Update()
    {
        Shoot();
    }
    //temp for shooting bullets 
   public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            Instantiate(bullet, shotSpawn.position, shotSpawn.rotation);
            
        }
    }

}