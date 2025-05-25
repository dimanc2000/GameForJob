using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSpawnSecond : MonoBehaviour
{
    public GameObject Snow;
    public Transform SnowPos;

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


        if (distance < 100)
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
        Instantiate(Snow, SnowPos.position, Quaternion.identity);
    }
}
