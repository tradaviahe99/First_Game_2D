using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    int score = 0;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
    }
    public void AddScore() { 
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
    }
}
