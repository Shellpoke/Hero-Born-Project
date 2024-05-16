using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        //Tells when player is in range
        if (other.name == "Player")
        {
            Debug.Log("Player detected - attack!");
        }
    }
    // 3
    void OnTriggerExit(Collider other)
    {
        //Tells when player is out of range
        if (other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
