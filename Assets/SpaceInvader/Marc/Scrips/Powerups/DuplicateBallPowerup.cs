using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateBallPowerup : Powerup
{
    public string ballTag = "Ball";

    public override void Activate()
    {
        // 1) get all active ball objects of scene
        GameObject[] balls = GameObject.FindGameObjectsWithTag(ballTag);
        //Debug.Log(balls.Length);


        // 2) for each active ball object, create a new object at the same position
        foreach (GameObject ball in balls)
        {
            ball.GetComponent<BallController>().CreateDuplicate();
        }

        // 3.5) what if x velocity ~= 0?
    }
}
