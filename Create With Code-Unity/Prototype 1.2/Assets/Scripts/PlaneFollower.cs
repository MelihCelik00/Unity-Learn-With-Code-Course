using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneFollower : MonoBehaviour
{
    [SerializeField] private GameObject _vehicle;
    [SerializeField] private Vector3 cameraDistanceOffset;
    
    void Update()
    {
        transform.position = _vehicle.transform.position + cameraDistanceOffset;
    }
}
