using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    float rotZ;
    [SerializeField] float rotationSpeed;
    
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }

    // Update is called once per frame
    void Update()
    {
        rotZ = rotationSpeed * Time.deltaTime; 
    }
}
