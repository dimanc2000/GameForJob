using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Animator anim;
    private States_enemy State
    {
        get { return (States_enemy)anim.GetInteger("state_enemy"); }
        set { anim.SetInteger("state_enemy", (int)value); }
    }

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        State = States_enemy.Idle;
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == Men.Instance.gameObject)
        {
            Men.Instance.GetDamage();
        }
    }*/

}

public enum States_enemy
{
    Idle
}