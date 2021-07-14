using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("StartScreen");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Level");
    }
}
