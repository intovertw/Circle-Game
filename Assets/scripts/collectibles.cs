using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5f;
    Vector2 movement;

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameManager.score++;
            Destroy(gameObject);
        }
        if (other.gameObject.tag.Equals("deleter"))
        {
            Destroy(gameObject);
        }
    }
}
