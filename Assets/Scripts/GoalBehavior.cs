using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour {
    public int playerOnePoints = 0;
    public int playerTwoPoints = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void printPoints() {
        GameObject.Find("Left Goal").GetComponent<GoalBehavior>().playerOnePoints = playerOnePoints;
        GameObject.Find("Right Goal").GetComponent<GoalBehavior>().playerTwoPoints = playerTwoPoints;

        Debug.Log($"Player One: {playerOnePoints}, Player Two: {playerTwoPoints}");
    }

    private void OnCollisionEnter(Collision other) {
        // Debug.Log("Goal collided with " + other.gameObject.name);
        if(other.gameObject.name == "GameBall" || other.gameObject.name == "GameBall(Clone)") {
            if(this.gameObject.name == "Left Goal") {
                playerTwoPoints++;

                Debug.Log("Player Two: scored 1 point.");
            } else if(this.gameObject.name == "Right Goal") {
                playerOnePoints++;
                Debug.Log("Player One: scored 1 point.");
            }
            printPoints();
        }

        if(playerOnePoints == 11) {
            Debug.Log("Game Over: Left Paddle wins!");
            playerOnePoints = 0;
            playerTwoPoints = 0;
            
            GameObject ball = GameObject.Find("GameBall");
            if(ball == null) {
                ball = GameObject.Find("GameBall(Clone)");
            }
            Destroy(ball);
        } 
        if(playerTwoPoints == 11) {
            Debug.Log("Game Over: Right Paddle wins!");
            playerOnePoints = 0;
            playerTwoPoints = 0;
            
            GameObject ball = GameObject.Find("GameBall");
            if(ball == null) {
                ball = GameObject.Find("GameBall(Clone)");
            }
            Destroy(ball);
        }
    }
}
