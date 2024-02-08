using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision) {
        // Debug.Log("PlayerOne collided with " + collision.gameObject.name);

        if(collision.gameObject.name == "GameBall" || collision.gameObject.name == "GameBall(Clone)") {
            // BoxCollider bc = GetComponent<BoxCollider>();
            // Bounds bounds = bc.bounds;
            // float maxX = bounds.max.x;
            // float minX = bounds.min.x;

            // Debug.Log($"maxX: {maxX}, minX: {minX}");

            Quaternion rotation = Quaternion.Euler(50f, 45f, 50f);
            Vector3 bounceDirection = rotation * Vector3.left;

            Rigidbody rb = collision.rigidbody;
            rb.AddForce(bounceDirection * 250f, ForceMode.Force);
        }
    } 
}
