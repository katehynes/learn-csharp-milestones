using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour 
{
    // when an object enters Enemy's sphere collider radius
    // note – other is of type Collider, not Collision
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Player detected - attack!");
        }
    }

    // when an object leaves the Enemy's sphere collider radius
    void OnTriggerExit(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }
} 
