using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    public GameObject player;
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    Vector2 movement;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");    
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            player.SetActive(false);
        }
        if (other.gameObject.tag.Equals("deleter"))
        {
            Destroy(gameObject);
        }
    }
}
