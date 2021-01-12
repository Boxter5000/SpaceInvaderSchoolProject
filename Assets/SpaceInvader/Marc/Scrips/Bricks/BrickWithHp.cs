using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickWithHp : Brick
{
    public int initialHp = 3;
    private int currentHp;

    private void Awake()
    {
        currentHp = initialHp;
    }

    protected override void OnBrickHit()
    {
        currentHp--;
        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
