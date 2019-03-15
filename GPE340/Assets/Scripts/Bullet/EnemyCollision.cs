using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{

    
// destorys everything other than the DeathZone 
    void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Enemy"))
        {
            Destroy(other.gameObject); //Tells it right here to destroy everything but itself 
}
    }
}
