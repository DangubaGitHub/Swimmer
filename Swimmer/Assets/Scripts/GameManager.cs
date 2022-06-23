using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIsIncreasing;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highScoreCount = PlayerPrefs.GetFloat("HighScore", highScoreCount);
        scoreCount = 0;
    }

    void Update()
    {
        ScoreCounting();
        HighScoreCounting();
    }

    void ScoreCounting()
    {
        if (scoreIsIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
    }

    void HighScoreCounting()
    {
        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;

            PlayerPrefs.SetFloat("HighScore", highScoreCount);
            PlayerPrefs.Save();
        }
    }
}
