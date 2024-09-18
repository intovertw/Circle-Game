using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    static public int score;
    static public bool playerAlive;

    public TMP_Text scoreText;

    private void Awake()
    {
        score = 0;
        playerAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        //handles score
        scoreText.text = score.ToString();
        Debug.Log(score);

        if(playerAlive == false)
        {
            Debug.Log("you suck ass");
        }
    }
}
