using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Transform tf;
    public int rotate = 0;


	// Use this for initialization
	void Start ()
    {
        tf = GetComponent<Transform>();

		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ItemSpin();
	}
    //block for making item spin have set to zero for now
    void ItemSpin()
    {
        tf.Rotate(0, rotate * Time.deltaTime, 0);
    }
    //pickup block for destorying object
    protected virtual void onPickup(GameObject target)
    {
        Destroy(gameObject);
    }
    public void OnTriggerEnter(Collider other)
    {
        onPickup(other.gameObject);
    }
}
