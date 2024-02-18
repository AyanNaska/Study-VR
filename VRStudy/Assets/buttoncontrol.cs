using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class buttoncontrol : MonoBehaviour
{
    [SerializeField] private Button activate;
    [SerializeField] private Button clear;
    [SerializeField] private TextMeshProUGUI scoreText; // Reference to your TextMeshPro object displaying the score
    private int score = 0;

    void IncrementScore()
    {
        score++;
        UpdateScoreText();
    }

    void DecrementScore()
    {
        score--;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (activate != null)
            {
                activate.onClick.Invoke();
            }
            else
            {
                Debug.LogWarning("clear Button is not assigned!");
            }
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (clear != null)
            {
                clear.onClick.Invoke();
            }
            else
            {
                Debug.LogWarning("clear Button is not assigned!");
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            IncrementScore();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            DecrementScore();
        }
    }
}