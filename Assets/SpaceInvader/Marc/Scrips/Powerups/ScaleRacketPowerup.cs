using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleRacketPowerup : Powerup
{
    public string playerTag = "Player";

    public float scaleFactor = 1f;

    public override void Activate()
    {
        GameObject player = GameObject.FindGameObjectWithTag(playerTag);
        if (player == null) return;

        RacketController racketController = player.GetComponent<RacketController>();
        if (racketController == null) return;

    }
}
