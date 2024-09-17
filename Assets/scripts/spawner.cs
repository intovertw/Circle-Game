using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] spikes;

    void Awake()
    {
        StartCoroutine("spawnTimer");
    }

    IEnumerator spawnTimer()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(3, 15));
            Instantiate(spikes[Random.Range(0,5)], transform.localPosition, transform.rotation);
        }
    }
}
