using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour {

    public GameBehavior gameManager;

    void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }

    void OnCollisionEnter(Collision collision) {
        // check if the colliding object is the player
        if(collision.gameObject.name == "Player")
        {
            // if it is, destroy the Item and display message that it is collected
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Item collected!");

            gameManager.Items += 1;
        }
    }
}