using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
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
        rb.velocity = new Vector2(direction.x, direction.y - 1000).normalized * force;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1.5)
        {
            Destroy(gameObject);
        }
    }
}
