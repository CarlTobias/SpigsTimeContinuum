using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class gameLogic : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;
    public GameObject GameOver;

    private void Start()
    {
        updateHighScore();
    }

    [ContextMenu("Add Score")]
    public void addScore(int scoreAdd)
    {
        playerScore += scoreAdd;
        scoreText.text = playerScore.ToString();
        checkHighScore();
    }

    public void checkHighScore()
    {
        if (playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
        }
        updateHighScore();
    }

    public void updateHighScore()
    {
        highScoreText.text = $"HighScore: {PlayerPrefs.GetInt("HighScore", 0)}";
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        GameOver.SetActive(true);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}