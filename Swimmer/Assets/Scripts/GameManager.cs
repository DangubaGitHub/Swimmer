using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIsIncreasing;

    EnemySpawner enemy_Spawner_Script;
    ParalaxBG paralaxBg_Script;
    ParalaxFG paralaxFg_Script;

    [Header("Scripts")]

    [SerializeField] GameObject EnemySpawner;
    [SerializeField] GameObject Background;
    [SerializeField] GameObject Sides;


    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        enemy_Spawner_Script = EnemySpawner.GetComponent<EnemySpawner>();
        paralaxBg_Script = Background.GetComponent<ParalaxBG>();
        paralaxFg_Script = Sides.GetComponent<ParalaxFG>();
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
        //Difficulty();

        if (scoreCount > 10)
        {
            paralaxBg_Script.scroleSpeed = -2f;
            paralaxFg_Script.scroleSpeed = -2.5f;
            enemy_Spawner_Script.timeBetweenSpawns = 4.5f;
            enemy_Spawner_Script.speed = 2.5f;
        }

        if (scoreCount > 20)
        {
            paralaxBg_Script.scroleSpeed = -2.5f;
            paralaxFg_Script.scroleSpeed = -3f;
            enemy_Spawner_Script.timeBetweenSpawns = 4f;
            enemy_Spawner_Script.speed = 3f;
        }

        if (scoreCount > 30)
        {
            paralaxBg_Script.scroleSpeed = -3f;
            paralaxFg_Script.scroleSpeed = -3.5f;
            enemy_Spawner_Script.timeBetweenSpawns = 3.5f;
            enemy_Spawner_Script.speed = 3.5f;
        }

        if (scoreCount > 40)
        {
            paralaxBg_Script.scroleSpeed = -3.5f;
            paralaxFg_Script.scroleSpeed = -4f;
            enemy_Spawner_Script.timeBetweenSpawns = 3f;
            enemy_Spawner_Script.speed = 4f;
        }

        if (scoreCount > 50)
        {
            paralaxBg_Script.scroleSpeed = -4f;
            paralaxFg_Script.scroleSpeed = -4.5f;
            enemy_Spawner_Script.timeBetweenSpawns = 2.5f;
            enemy_Spawner_Script.speed = 4.5f;
        }

        if (scoreCount > 60)
        {
            paralaxBg_Script.scroleSpeed = -4.5f;
            paralaxFg_Script.scroleSpeed = -5f;
            enemy_Spawner_Script.timeBetweenSpawns = 2f;
            enemy_Spawner_Script.speed = 5f;
        }

        if (scoreCount > 70)
        {
            paralaxBg_Script.scroleSpeed = -5f;
            paralaxFg_Script.scroleSpeed = -5.5f;
            enemy_Spawner_Script.timeBetweenSpawns = 1.5f;
            enemy_Spawner_Script.speed = 5.5f;
        }

        if (scoreCount > 80)
        {
            paralaxBg_Script.scroleSpeed = -5.5f;
            paralaxFg_Script.scroleSpeed = -6f;
            enemy_Spawner_Script.timeBetweenSpawns = 1f;
            enemy_Spawner_Script.speed = 6f;
        }

        if (scoreCount > 100)
        {
            paralaxBg_Script.scroleSpeed = -6f;
            paralaxFg_Script.scroleSpeed = -6.5f;
            enemy_Spawner_Script.timeBetweenSpawns = 1f;
            enemy_Spawner_Script.speed = 6.5f;
        }

        if (scoreCount > 200)
        {
            paralaxBg_Script.scroleSpeed = -6.5f;
            paralaxFg_Script.scroleSpeed = -7f;
            enemy_Spawner_Script.timeBetweenSpawns = .75f;
            enemy_Spawner_Script.speed = 7f;
        }

        if (scoreCount > 400)
        {
            paralaxBg_Script.scroleSpeed = -7f;
            paralaxFg_Script.scroleSpeed = -7.5f;
            enemy_Spawner_Script.timeBetweenSpawns = .5f;
            enemy_Spawner_Script.speed = 7.5f;
        }
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

    /*public void Difficulty()
    {
        switch(scoreCount)
        {
            case 10:
                paralaxBg_Script.scroleSpeed -= .5f;
                paralaxFg_Script.scroleSpeed -= .5f;
                enemy_Spawner_Script.timeBetweenSpawns -= .5f;
                Bacteria.instance.speed += .5f;
                break;

            case 20:
                paralaxBg_Script.scroleSpeed -= .5f;
                paralaxFg_Script.scroleSpeed -= .5f;
                enemy_Spawner_Script.timeBetweenSpawns -= .5f;
                Bacteria.instance.speed += .5f;
                break;

            case 30:
                paralaxBg_Script.scroleSpeed -= .5f;
                paralaxFg_Script.scroleSpeed -= .5f;
                enemy_Spawner_Script.timeBetweenSpawns -= .5f;
                Bacteria.instance.speed += .5f;
                break;

            case 40:
                paralaxBg_Script.scroleSpeed -= .5f;
                paralaxFg_Script.scroleSpeed -= .5f;
                enemy_Spawner_Script.timeBetweenSpawns -= .5f;
                Bacteria.instance.speed += .5f;
                break;

            case 50:
                paralaxBg_Script.scroleSpeed -= .5f;
                paralaxFg_Script.scroleSpeed -= .5f;
                enemy_Spawner_Script.timeBetweenSpawns -= .5f;
                Bacteria.instance.speed += .5f;
                break;
        }
    }*/
}
