using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour {
    private float unitsPerSecond = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate() {
        float horizontalValue = Input.GetAxis("Horizontal");
        Vector3 force = Vector3.right * horizontalValue * unitsPerSecond;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(force, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision) {
        // Debug.Log("PlayerOne collided with " + collision.gameObject.name);

        // BoxCollider bc = GetComponent<BoxCollider>();
        // Bounds bounds = bc.bounds;
        // float maxX = bounds.max.x;
        // float minX = bounds.min.x;

        // Debug.Log($"maxX: {maxX}, minX: {minX}");

        Quaternion rotation = Quaternion.Euler(60f, 62f, 60f);
        Vector3 bounceDirection = rotation * Vector3.up;

        Rigidbody rb = collision.rigidbody;
        rb.AddForce(bounceDirection * 1000f, ForceMode.Force);
    }   
}
