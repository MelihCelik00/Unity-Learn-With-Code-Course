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
    [SerializeField] private float driftSpeed;
    
    
    private void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis(axisName: "Horizontal");
        verticalInput = Input.GetAxis(axisName: "Vertical");

        // The vehicle will move
        transform.Translate(translation: Vector3.forward * (Time.deltaTime * speedOffset * verticalInput));
        transform.Rotate(eulers: Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));

        if (Input.GetKey(key: KeyCode.LeftShift) && Math.Abs(value: verticalInput) > 0)
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * driftSpeed * horizontalInput));
        }
    }
}
