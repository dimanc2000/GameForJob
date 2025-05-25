using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject Bullet;
    public Transform BulletPos;

    public SpriteRenderer sprite;

    private float timer;
    private GameObject player;

    void Start()
    {
        sprite = GetComponentInParent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        timer += Time.deltaTime;

        float distance = Vector2.Distance(transform.position, player.transform.position);

        if (transform.position.x < player.transform.position.x)
        {
            sprite.flipX = false;
        }
        if (transform.position.x > player.transform.position.x)
        {
            sprite.flipX = true;
        }

        if (distance < 7)
        {
            timer += Time.deltaTime;

            if (timer > 3)
            {
                timer = 0;
                shoot();
            }
        }

    }

    void shoot()
    {
        Instantiate(Bullet, BulletPos.position, Quaternion.identity);
    }
}
