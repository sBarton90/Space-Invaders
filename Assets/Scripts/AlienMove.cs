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

    public void CollisionDetected(AlienCollisionDetect collisionDetect) {
        Vector2 moveDown = new Vector2(0, -.05f);
        transform.Translate(moveDown);
        collided ^= true;
    }
}
