using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("General")] 
    [SerializeField] 
    private int _score;

    [Header("UI")] 
    [SerializeField] 
    private TextMeshProUGUI _scoreText;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
    }

    public void AddScore()
    {
        _score++;
        UpdateScore();
    }

    // Update is called once per frame
    private void UpdateScore()
    {
        _scoreText.text = "Score: " + _score;
        //_scoreText.text = string.Format("Score: {0}", _score);
    }
}
