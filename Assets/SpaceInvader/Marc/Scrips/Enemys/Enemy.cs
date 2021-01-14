using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemySpawner spawner;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        OnEnemyHit();
    }

    private void OnDestroy()
    {
        spawner.OnBeforeEnemyDestroyed(this);
    }

    public void SetEnemySpawner(EnemySpawner spawner)
    {
        this.spawner = spawner;
    }

    protected virtual void OnEnemyHit()
    {
        Destroy(gameObject);
    }
}
