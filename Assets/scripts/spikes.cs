using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spikes : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 5f;
    Vector2 movement;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");    
    }

    private void Update()
    {
        //spike speedup after 10 points
        if (gameManager.score >= 10)
        {
            moveSpeed = 10f;
        }
    }

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            gameManager.playerAlive = false;
            player.SetActive(false);
        }
        if (other.gameObject.tag.Equals("deleter"))
        {
            Destroy(gameObject);
        }
    }
}
