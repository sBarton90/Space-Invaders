using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienCollisionDetect : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        transform.parent.GetComponent<AlienMove>().CollisionDetected(this);
    }
}
