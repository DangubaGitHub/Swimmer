using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    float rotZ;
    [SerializeField] float rotationSpeed;

    Rigidbody2D rb2d;
    float speed;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb2d.velocity = new Vector2()
    }

    // Update is called once per frame
    void Update()
    {
        rotZ += Time.deltaTime * rotationSpeed;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
