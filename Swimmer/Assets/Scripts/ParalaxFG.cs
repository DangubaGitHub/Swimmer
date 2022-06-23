using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxFG : MonoBehaviour
{
    public float scroleSpeed = -2f;
    Vector2 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scroleSpeed, 10);
        transform.position = startPos + Vector2.up * newPos;
    }
}
