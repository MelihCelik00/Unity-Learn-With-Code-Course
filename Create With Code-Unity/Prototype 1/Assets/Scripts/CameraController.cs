using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] private GameObject vehicle;
    [SerializeField] private Vector3 OffSetDistance;
    
    
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = vehicle.transform.position + OffSetDistance;
    }
}
