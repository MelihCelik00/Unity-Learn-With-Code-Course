using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalInput;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float xRange;
    [SerializeField] private GameObject projectilePrefab;
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        CheckRange();
        MoveHorizontal();
        CheckShooting();
    }

    private void MoveHorizontal()
    {
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
    }

    private void CheckRange()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
    
    private void CheckShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
    
    
}
