using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spikes;
    float timerMin = 5f, timerMax = 15f;

    void Awake()
    {
        StartCoroutine("spawnTimer");
    }

    IEnumerator spawnTimer()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(timerMin, timerMax));
            Instantiate(spikes[Random.Range(0, 5)], transform.localPosition, transform.rotation);

            if(gameManager.score >= 100)
            {
                timerMin = 1f;
                timerMax = 2f;
            }
        }
    }
}
