using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ufo;
    float timer;

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
}
