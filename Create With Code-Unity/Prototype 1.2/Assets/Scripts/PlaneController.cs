using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    private float _horizontalInput;
    private float _verticalInput;

    [SerializeField] private int turnSpeed;
    [SerializeField] private int altitudeControlSpeed;
    [SerializeField] private int velocity;
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
        
        CheckMovementMethods();
    }

    private void CheckMovementMethods()
    {
        Move();
        Turn();
        AltitudeControl();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MoveAmongTheLocalAxis(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            MoveAmongTheLocalAxis(Vector3.back);
        }
    }

    private void Turn()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            HorizontalRotation(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            HorizontalRotation(Vector3.forward);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            VerticalRotation(Vector3.down);
        }

        if (Input.GetKey(KeyCode.D))
        {
            VerticalRotation(Vector3.up);
        }
    }

    private void AltitudeControl()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            VerticalRotation(Vector3.left);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            VerticalRotation(Vector3.right);
        }
    }

    private void MoveAmongTheLocalAxis(Vector3 side)
    {
        transform.Translate(side * (Time.deltaTime * velocity));
    }

    private void HorizontalRotation(Vector3 horizontalDirection)
    {
        transform.Rotate(horizontalDirection * (Time.deltaTime * turnSpeed * _horizontalInput * -1));
    }

    private void VerticalRotation(Vector3 verticalDirection)
    {
        transform.Rotate(verticalDirection * (Time.deltaTime * turnSpeed * _verticalInput));
    }

}
