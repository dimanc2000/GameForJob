using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{

    public GameObject Gift;
    public Transform GiftPos;

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


        if (distance < 15)
        {
            timer += Time.deltaTime;

            if (timer > 4)
            {
                timer = 0;
                shoot();
            }
        }

    }

    void shoot()
    {
        Instantiate(Gift, GiftPos.position, Quaternion.identity);
    }
}
