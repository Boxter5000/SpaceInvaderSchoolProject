using UnityEngine;

public class Brick : MonoBehaviour
{
    private BrickSpawner spawner;

    public PowerupSpawnConfig powerupSpawnConfig;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnBrickHit();
    }

    private void OnDestroy()
    {
        spawner.OnBeforeBrickDestroyed(this);
    }

    public void SetBrickSpawner(BrickSpawner spawner)
    {
        this.spawner = spawner;
    }

    protected virtual void OnBrickHit()
    {
        SpawnRandomPowerup();
        Destroy(gameObject);
    }

    protected virtual void SpawnRandomPowerup()
    {
        // 1) get random powerup from powerupSpawnConfig
        Powerup newPowerup = powerupSpawnConfig.GetRandomPowerup();

        // 1.5) return if no valid powerup prefab received
        if (newPowerup == null)
        {
            return;
        }

        // 2) instantiate powerup prefab instance
        Instantiate(newPowerup, transform.position, Quaternion.identity);
    }
}
