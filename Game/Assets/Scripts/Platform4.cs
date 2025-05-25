using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform4 : MonoBehaviour
{
    bool move;
    float speed = 3f;

    void FixedUpdate()
    {
        if (transform.position.y > -27f)
        {
            move = false;
        }
        if (transform.position.y < -37f)
        {
            move = true;
        }
        if (move)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.fixedDeltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.fixedDeltaTime);
        }
    }
}
