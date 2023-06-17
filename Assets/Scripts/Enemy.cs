using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;
    public int damage;
    public float distance;
    public LayerMask IsPlayer;
    public GameObject player;
  

 
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, transform.up, distance, IsPlayer);
        if (hitinfo.collider != null)
        {
            if (hitinfo.collider.CompareTag("Player"))
            {
                hitinfo.collider.GetComponent<Hero>().changeHealth(damage);
               
            }
          
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
       
    }
}
