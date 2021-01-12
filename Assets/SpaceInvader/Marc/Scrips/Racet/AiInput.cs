using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiInput : MonoBehaviour , IInput
{

    public Transform aiMovementTarget;
    float input;

    void Update()
    {

        if (aiMovementTarget != null)
        {
            if (aiMovementTarget.position.x < transform.position.x)
            {
                // move right
                input = 1f;
            }
            else
            {
                // move left
                input = -1f;
            }
        }
        else
        {
            //GameObject targetObject = GameObject.Find("Ball");

            BallController ball = GameObject.FindObjectOfType<BallController>();

            if (ball != null)
            {
                aiMovementTarget = ball.transform;
            }
            else
            {
                Debug.LogError("AiMovementTarget has not been assigned!");
            }
        }
    }
    public float GetInput()
    {
        return input;
    }
}
