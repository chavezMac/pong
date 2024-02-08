using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColor : MonoBehaviour {
    public Color[] colors = new Color[4];
    
    public int colorIndex = 0;
    // Start is called before the first frame update
    void Start() {
        colors[0] = Color.red;
        colors[1] = Color.blue;
        colors[2] = Color.green;
        colors[3] = Color.yellow;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeColor() {
        if(colorIndex < colors.Length - 1) {
            colorIndex++;
        } else {
            colorIndex = 0;
        }

        transform.GetComponent<Renderer>().material.color = colors[colorIndex];
    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "Left Paddle" || other.gameObject.name == "Right Paddle") {
            ChangeColor();
        }
    }
}
