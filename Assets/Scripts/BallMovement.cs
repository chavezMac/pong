using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {
    void Start() {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.back * 550f, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision) {
        // Debug.Log("Ball collided with " + collision.gameObject.name)

        if(collision.gameObject.name == "Left Goal" || collision.gameObject.name == "Right Goal") {
            //Debug.Log("Ball collided with Left Goal");

            transform.position = new Vector3(0, 0, 0);
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            
            if(collision.gameObject.name == "Left Goal") {
                rb.AddForce(Vector3.back * 550f, ForceMode.Force);
            }
            
            if(collision.gameObject.name == "Right Goal"){
                rb.AddForce(Vector3.forward * 550f, ForceMode.Force);   
            } 
        }

    }
    
    // Update is called once per frame
    void Update() {

    }

}
