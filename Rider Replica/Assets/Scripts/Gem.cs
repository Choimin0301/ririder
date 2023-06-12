using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    ScoreManager _scoreManager;

    private void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    } 

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            _scoreManager.AddScore(1);
            Destroy(gameObject);
        }   
    }
}
