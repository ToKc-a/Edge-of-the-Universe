using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverText;

    int playerScore = 0;

    public void AddScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void PlayerDied()
    {
        SceneManager.LoadScene("GameOverScreen");
        Time.timeScale = 2;
    }
}
