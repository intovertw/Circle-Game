using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class gameManager : MonoBehaviour
{
    static public int score;
    static public bool playerAlive;

    public GameObject[] topAndBottomSpawners;
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

        //after 25 points, activate bottom and top spawners
        if(gameManager.score >= 25)
        {
            for(int i = 0; i < topAndBottomSpawners.Length; i++)
            {
                topAndBottomSpawners[i].SetActive(true);
            }
        }

        //game over
        if(playerAlive == false)
        {
            Debug.Log("you suck ass");
        }
    }
}
