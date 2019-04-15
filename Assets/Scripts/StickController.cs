using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    float verticalSpeed = 2.0f;
    float horizontalSpeed = 2.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = transform.position;
    }

    void Update()
    {
        // Get the mouse delta.
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = - verticalSpeed * Input.GetAxis("Mouse Y");
        // Apply it to the rigidBody in order to support physics.
        rb.angularVelocity = new Vector3(v,h,0);
    }
}
