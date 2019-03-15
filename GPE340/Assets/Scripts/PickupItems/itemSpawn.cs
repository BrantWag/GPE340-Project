using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawn : MonoBehaviour
{
    public float spawnTime;
    public GameObject spawn;


    private Transform tf;
    private float respawnTimeLimit;
    private GameObject spawnedObject;

    private void Awake() 
    {
        tf = GetComponent<Transform>();
    }

    // Use this for initialization
    void Start ()
    {
        Spawn();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (spawnedObject != null)
        {
            return;
        }

        respawnTimeLimit -= Time.deltaTime;

        if (respawnTimeLimit <= 0)
        {
            Spawn();
        }
		
	}

    public void Spawn()
    {
        spawnedObject = Instantiate(spawn, tf.position, tf.rotation);

        respawnTimeLimit = spawnTime;
    }
}
