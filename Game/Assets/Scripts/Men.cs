using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Men : MonoBehaviour
{
    [SerializeField] private float speed = 3.5f;
    [SerializeField] public float jumpForce = 5.5f;
    [SerializeField] public float doubleJumpForce = 4f;
    public bool isGrounded = false;

    public Joystick joystick;

    public Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    public int doubleJump = 0;
    public int doubleJumpValue = 1;

    public static Men Instance { get; set; }

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }

    private void Awake()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update() 
    {
        if (isGrounded) State = States.Idle;
        if (joystick.Horizontal != 0)
            Run();
        if (isGrounded)
            doubleJump = 0;
    }

    private void Run()
    {
        if (isGrounded) State = States.Running;

        Vector3 dir = new Vector3 (joystick.Horizontal, 0, 0);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, 0.1f);
        isGrounded = collider.Length > 1;
        if (!isGrounded) State = States.Jump;
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("platform"))
        {
            this.transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("platform"))
        {
            this.transform.parent = null;
        }
    }

}

public enum States
{
    Idle,
    Running,
    Jump
}