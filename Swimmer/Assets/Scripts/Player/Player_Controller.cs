using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] float speed;
    float move;
    Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
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
        rb2D.velocity = new Vector2(move * speed, 0);
    }
}
