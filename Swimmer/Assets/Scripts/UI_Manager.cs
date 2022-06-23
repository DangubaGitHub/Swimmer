using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Score;

    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;

    public bool menuIsOn;

    void Start()
    {
        MenuOn();
        GameManager.instance.scoreIsIncreasing = false;
    }

    void Update()
    {
        UpdateScore();
        UpdateHighScore();
    }

    public void PlayGame()
    {
        Menu.SetActive(false);
        Score.SetActive(true);
        Time.timeScale = 1;
        menuIsOn = false;
        GameManager.instance.scoreIsIncreasing = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        GameManager.instance.highScoreCount = 0;
        UpdateHighScore();
    }

    public void MenuOn()
    {
        Time.timeScale = 0f;
        Menu.SetActive(true);
        Score.SetActive(false);
        menuIsOn = true;
    }

    void UpdateScore()
    {
        scoreText.text = Mathf.Round(GameManager.instance.scoreCount).ToString();
    }

    public void UpdateHighScore()
    {
        highScoreText.text = Mathf.Round(GameManager.instance.highScoreCount).ToString();
    }
}
