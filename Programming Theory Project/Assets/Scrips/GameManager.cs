using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    private int score;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            if (value < 0)
            {
                score = 0;
                return;
            }
            score = value;
        }

    }
    private bool isGameActive;
    public bool IsGameActive { get; set; }

    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;


    void Start()
    {
        IsGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGameActive && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    public void UpdateScore()
    {
        Score++;
        scoreText.text = "Score: " + Score;
    }

    public void GameOver()
    {
        IsGameActive = false;
        gameOverText.SetActive(true);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Main");
    }
}
