using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    [SerializeField] private TextMeshProUGUI ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        //TextMeshProUGUI ScoreText = FindObjectOfType<TextMeshPro>;
        Score = 0;
    }
    public void AddScore(int a)
    {
        Score+=a;
        
    }
    // Update is called once per frame
    void Update()
    {
       ScoreText.text = Score.ToString();
    }
}
