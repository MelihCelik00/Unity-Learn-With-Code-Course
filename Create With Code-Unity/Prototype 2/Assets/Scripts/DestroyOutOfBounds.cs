using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topLimitBoundary;
    [SerializeField] private float lowLimitBoundary;
    
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topLimitBoundary)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowLimitBoundary )
        {
            Destroy(gameObject);
        }
    }
}
