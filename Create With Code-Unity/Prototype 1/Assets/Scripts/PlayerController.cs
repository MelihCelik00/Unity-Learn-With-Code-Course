using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speedOffset;

    [SerializeField] private float turnSpeed;

    [SerializeField] private float horizontalInput;
    [SerializeField] private float verticalInput;

    private void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        // The vehicle will move
        transform.Translate(Vector3.forward * (Time.deltaTime * speedOffset * verticalInput));
        transform.Translate(Vector3.right * (Time.deltaTime * turnSpeed * horizontalInput));
    }
}
