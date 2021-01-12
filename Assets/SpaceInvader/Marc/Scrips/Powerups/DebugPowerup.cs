using UnityEngine;

public class DebugPowerup : Powerup
{
    public string message = "DebugPowerup activated!";

    public override void Activate()
    {
        Debug.Log(message);
    }
}
