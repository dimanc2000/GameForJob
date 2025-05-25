using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1 : MonoBehaviour
{
    bool move;
    float speed = 2f;

    void FixedUpdate()
    {
        if (transform.position.y > -54f)
        {
            move = false;
        }
        if (transform.position.y < -68f)
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
