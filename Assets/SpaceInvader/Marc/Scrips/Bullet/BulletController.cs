using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float BulletSpeed = 1f;
    public float bulletLifeTime = 2f;
    
    private Rigidbody2D rb2d;

    public void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    public void FixedUpdate()
    {
        rb2d.velocity = new Vector3(0f, BulletSpeed * Time.deltaTime, 0f);
    }

    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(bulletLifeTime);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       Destroy(gameObject);
    }
}
