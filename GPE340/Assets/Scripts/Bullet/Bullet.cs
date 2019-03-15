using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform tf;
    public float speed;
    public float time;

    // Use this for initialization
    void Start()
    {
        tf = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Destroy(this.gameObject, time);
    }

    //Tells bullet to move 
    public void Move()
    {
        transform.Translate(0,0, Time.deltaTime * speed);
    }
}