using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBallPowerup : Powerup
{
    public float ScaleFactor = 1f;
    public string ScaleTag = "Ball";

    public override void Activate()
    {
        GameObject Balls = GameObject.FindGameObjectWithTag(ScaleTag);
        if (Balls == null) return;

        BallController ballController = Balls.GetComponent<BallController>();
        if (ballController == null) return;

        ballController.ScaleBall(ScaleFactor);
    }
}
