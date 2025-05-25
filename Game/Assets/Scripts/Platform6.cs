using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform6 : MonoBehaviour
{
    bool move;
    float speed = 2f;

    void FixedUpdate()
    {
        if (transform.position.x > 100f || transform.position.y > 3f)
        {
            move = false;
        }
        if (transform.position.x < 84f || transform.position.y < -10f)
        {
            move = true;
        }
        if (move)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.fixedDeltaTime, transform.position.y + speed * Time.fixedDeltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.fixedDeltaTime, transform.position.y - speed * Time.fixedDeltaTime);
        }
    }
}
