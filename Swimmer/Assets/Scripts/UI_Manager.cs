using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] GameObject Menu;
    [SerializeField] GameObject Score;



    void Start()
    {
        Score.SetActive(false);
    }

    void Update()
    {
        
    }

    public void PlayGame()
    {
        Menu.SetActive(false);
        Score.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResetScore()
    {

    }
}
