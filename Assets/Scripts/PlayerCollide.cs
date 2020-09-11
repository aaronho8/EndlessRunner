using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollide : MonoBehaviour

{
    public PlayerMovement movement;
    public SpawnManager spawnManager;

    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            

        }

    }
    public void OnTriggerEnter(Collider other){
        spawnManager.SpawnTriggerEntered();
    }
    
}
