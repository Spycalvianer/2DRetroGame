using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnClouds : MonoBehaviour
{
    public GameObject cloudSpawned;

    public IEnumerator TimerForSpawning()
    {
        while (true) 
        {
            yield return new WaitForSeconds(2f);
            InstantiateClouds();
        }
    }
    public void InstantiateClouds()
    {
        Instantiate(cloudSpawned, new Vector3(Random.Range(-10, 10), Random.Range(-9, -13), 0), Quaternion.identity);
        cloudSpawned.transform.localScale = new Vector3(Random.Range(0.1f, 2), Random.Range(0.1f, 1.5f), 1);
    }
}
