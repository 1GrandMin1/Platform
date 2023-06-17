using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int health;
    [SerializeField] private float _speed = 3f;
    //[SerializeField] private int _lives = 5;
    [SerializeField] private float _jump = 15f;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private bool _isGround = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if (_isGround && Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }
    private void FixedUpdate()
    {
        CheckGround();
    }
    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, _speed * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
    }
    private void Jump()
    {
        rb.AddForce(transform.up * _jump, ForceMode2D.Impulse);
    }
    private void CheckGround()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.3f);
        _isGround = colliders.Length > 1;
    }
    public void changeHealth(int healthValue)
    {
        health -= healthValue;
    }




}
