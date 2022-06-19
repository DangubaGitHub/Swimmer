using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bacteria : MonoBehaviour
{
    float rotZ;
    [SerializeField] float rotationSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotZ += Time.deltaTime * rotationSpeed;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
