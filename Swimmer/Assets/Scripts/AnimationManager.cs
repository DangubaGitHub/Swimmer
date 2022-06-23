using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{


    public const string EMERGE = "Player_Emerge";

    string currentState;

    Animator anim;

    UI_Manager ui_Manager_Script;
    [SerializeField] GameObject UICanvas;

    public static AnimationManager instance;

    private void Awake()
    {
        instance = this;
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;

        anim.Play(newState);

        currentState = newState;
    }
}
