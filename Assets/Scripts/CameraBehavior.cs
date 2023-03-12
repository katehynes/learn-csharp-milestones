using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {
    // stores the distance we want b/w main cam and Player
    public Vector3 camOffset = new Vector3(0f, 1.2f, -2.6f);

    // creates a variable to hold the player capsule's Transform info
    private Transform target;

    void Start() {
        // locates the capsule by name & retrieves Transform property from the scene
        target = GameObject.Find("Player").transform;
    }

    // executes after Update
    void LateUpdate() {
        // calculate & return cam's relative position in world space
        // which returns pos of player, offset by 0 in x, 1.2 in y, -2.6 in z
        this.transform.position = target.TransformPoint(camOffset);

        // updates camera rotation to focus on the pos of target, player
        this.transform.LookAt(target);
    } 
} 
