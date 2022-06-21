using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    float rotZ;
    [SerializeField] float rotationSpeed;

    Rigidbody2D rb2d;
    float speed = 2f;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb2d.velocity = new Vector2(0, -1 * speed);
    }

    void Update()
    {
        rotZ += Time.deltaTime * rotationSpeed;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);
        }
    }
}
