using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    bool move;
    float speed = 2f;

    void FixedUpdate()
    {
        if (transform.position.x > 105f || transform.position.y > -50f)
        {
            move = false;
        }
        if (transform.position.x < 88f || transform.position.y < -68f)
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
