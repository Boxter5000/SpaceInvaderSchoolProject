using UnityEngine;

[CreateAssetMenu]
public class PowerupSpawnConfig : ScriptableObject
{
    [SerializeField]
    private Powerup[] powerupPrefabs;

    // get random powerup
    public Powerup GetRandomPowerup()
    {
        if (powerupPrefabs != null && powerupPrefabs.Length > 0)
        {
            int randomIndex = Random.Range(0, powerupPrefabs.Length);
            return powerupPrefabs[randomIndex];
        }

        Debug.LogWarning("No powerup prefabs set up.");
        return null;
    }
}
