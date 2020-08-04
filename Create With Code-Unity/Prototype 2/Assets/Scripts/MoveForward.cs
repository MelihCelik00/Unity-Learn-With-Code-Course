using System;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
