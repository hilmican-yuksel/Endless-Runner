using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    private Transform karakter;

    private float yOffset = -1f;
    private float zOffset = -5f;
    void Start()
    {
        karakter = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(karakter.position.x, karakter.position.y - yOffset, karakter.position.z + zOffset); ;
    }
}
