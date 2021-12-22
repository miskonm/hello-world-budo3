using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public float moveSpeed;
    private int a1;
    private float a2;
    private string a3;
    private bool a4;

    private Vector2 v2;
    private Vector3 v3;
    
    private void Awake()
    {
        Debug.Log($"Awake");
    }

    private void Start()
    {
        Debug.Log($"Start");
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log($"GetKeyDown Frame {Time.frameCount}");
        }

        float axis = Input.GetAxis("Horizontal");
        float move = axis * moveSpeed;

        Vector3 pos = transform.position;
        pos.x += move;
        transform.position = pos;
        
        Debug.Log($"GetAxis axis {axis}");

        if (Input.GetButton("Jump"))
        {
            Debug.Log($"GetKey Frame {Time.frameCount}");
        }
        
        if (Input.GetButtonUp("Jump"))
        {
            Debug.Log($"GetKeyUp Frame {Time.frameCount}");
        }
    }

    private void Test()
    {
        Debug.Log($"Test");
    }
}
