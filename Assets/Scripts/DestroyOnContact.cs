using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Alien" || other.gameObject.tag == "UFO") {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
