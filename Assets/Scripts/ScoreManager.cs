using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    private static int _score = 0;
    [SerializeField]
    private TextMeshProUGUI _scoreText;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScoreText();
    }

    public int GetScore() => _score;
    public int SetScore(int score) => _score = score;

    public void AddScore(int score)
    {
        _score += score;
    }

    public void RemoveScore(int score)
    {
        _score -= score;
    }

    public void UpdateScoreText()
    {
        _scoreText.text = _score.ToString();
    }

    public void ResetScore()
    {
        _score = 0;
    }
}
