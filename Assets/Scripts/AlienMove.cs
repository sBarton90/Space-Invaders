using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMove : MonoBehaviour
{
    private float timer = 0;
    private float timeToMove = 0.5f;
    private float moveAmount = .25f;
    private bool collided;
    
    void Update()
    {
        if (!collided) {
            MoveGroup(moveAmount);
        } else {
            MoveGroup(-moveAmount);
        }
        
    }

    void MoveGroup(float moveAmount) {
        timer += Time.deltaTime;
        if (timer > timeToMove) {
            transform.Translate(new Vector2(moveAmount, 0));
            timer = 0;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Right Wall") {
            collided = true;
        }
        if (other.gameObject.tag == "Left Wall") {
            collided = false;
        }
    }
}
