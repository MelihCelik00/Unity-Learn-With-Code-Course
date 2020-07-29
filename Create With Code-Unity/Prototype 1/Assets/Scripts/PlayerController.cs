using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speedOffset;
    void Update()
    {
        // The vehicle will move
        transform.Translate(Vector3.forward * (Time.deltaTime * speedOffset));
    }
}
