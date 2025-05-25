using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballThird2 : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;
    public float force = 5f;
    private float timer;
    private int hp;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = transform.position;
        rb.velocity = new Vector2(direction.x - 225, direction.y - 200).normalized * force;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            Destroy(gameObject);
        }
    }
}
