using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ufo;
    [SerializeField] Text playersScore;
    float timer;
    int playerScore = 0;

    void Start() {
        UpdateScore();
    }
    void Update() {
        timer += Time.deltaTime;
        SpawnUFO();
    }
    void SpawnUFO() {
        
        if (timer >= 3) {
            if (Random.value <= 0.25) {
                Instantiate(ufo);
            }
            timer = 0;
        }
    }

    public void AddToScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        UpdateScore();
    }

    void UpdateScore() {
        playersScore.text = "Score: " + playerScore;
    }
}
