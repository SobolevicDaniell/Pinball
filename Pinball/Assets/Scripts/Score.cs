using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score: Loader<Score>
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private int _score;

    
    
    private void Awake()
    {
        _scoreText = FindObjectOfType<TextMeshProUGUI>();
        _score = 0;
    }


    public int ScoreTotal
    {
        get
        {
            return _score;
        }
        set
        {
            _score = value;
            _scoreText.text = "Score: " + _score.ToString();
        }
    }
    
    public void AddScore(int score)
    {
        ScoreTotal += score;
        _scoreText.text = "Score: " + _score.ToString();
    }
}
