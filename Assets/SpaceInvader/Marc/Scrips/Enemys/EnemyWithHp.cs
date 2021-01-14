using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWithHp : Enemy
{
    public int initialHp = 3;
    private int currentHp;

    private void Awake()
    {
        currentHp = initialHp;
    }

    protected override void OnEnemyHit()
    {
        currentHp--;
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
