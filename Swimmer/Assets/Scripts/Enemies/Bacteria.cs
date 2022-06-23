using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    float rotZ;
    [SerializeField] float rotationSpeed;

    Rigidbody2D rb2d;
    public float speed;

    public static Bacteria instance;

    private void Awake()
    {
        instance = this;
        rb2d = GetComponent<Rigidbody2D>();
        speed = 2f;
        
    }

    void Start()
    {
        transform.position = new Vector2(0, -1);
        rb2d.AddForce(transform.up * speed);
        //rb2d.velocity = new Vector2(0, -1) * speed;
    }

    void Update()
    {
        rotZ += Time.deltaTime * rotationSpeed;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (GameManager.instance.scoreCount > 10)
        {
            speed = 2000f;
        }
        if (GameManager.instance.scoreCount > 20)
        {
            speed = 50000f;
        }

        if (GameManager.instance.scoreCount > 30)
        {
            speed = 50f;
        }

        if (GameManager.instance.scoreCount > 40)
        {
            rb2d.gravityScale = 5;
            //speed = 44f;
        }

        if (GameManager.instance.scoreCount > 50)
        {
            speed = 27f;
        }

        if (GameManager.instance.scoreCount > 60)
        {
            speed = 32f;
        }

        if (GameManager.instance.scoreCount > 70)
        {
            speed = 37f;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
