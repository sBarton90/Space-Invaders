using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnContact : MonoBehaviour
{

    GameManager gameManager;
    int alienScore = 100;
    int ufoScore = 500;
    void Start() {
        GameObject gameManagerObject = GameObject.FindWithTag("GameManager");
        if (gameManagerObject != null) {
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Alien" || other.gameObject.tag == "UFO") {
            if (other.gameObject.tag == "Alien") {
                gameManager.AddToScore(alienScore);
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            } else {
                gameManager.AddToScore(ufoScore);
                Destroy(other.gameObject);
                Destroy(this.gameObject);
            }
        }
    }
}
