using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] float speed;
    float move;
    Rigidbody2D rb2D;

    UI_Manager ui_Manager_Script;
    [SerializeField] GameObject UICanvas;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        ui_Manager_Script = UICanvas.GetComponent<UI_Manager>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");        
    }

    void FixedUpdate()
    {
        if (!ui_Manager_Script.menuIsOn)
        {
             rb2D.velocity = new Vector2(move * speed, 0);        
        }
    }
}
