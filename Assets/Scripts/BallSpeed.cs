using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpeed : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;
        velocity.Normalize();
        velocity *= speed;

        GetComponent<Rigidbody>().velocity = velocity;

    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "Left Paddle" || other.gameObject.name == "Right Paddle") {
            speed += 2.0f;
            // Debug.Log($"Ball speed: {speed}");
        }

        if(other.gameObject.name == "Left Goal" || other.gameObject.name == "Right Goal") {
            speed = 5.0f;
        }
    }
}
