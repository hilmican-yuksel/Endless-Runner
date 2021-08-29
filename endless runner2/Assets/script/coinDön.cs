using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinDön : MonoBehaviour
{
    private float rotationSpeed = 180f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
