using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaterBottle : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    private float timeBetweenSpawning;
    public IEnumerator TimerForSpawning()
    {
        while (true)
        {
            timeBetweenSpawning = Random.Range(1,6);
            yield return new WaitForSeconds(timeBetweenSpawning);
            Instantiatebottles();
        }
    }
    public void Instantiatebottles()
    {
        Instantiate(ObjectToSpawn, new Vector3(Random.Range(-10, 10), Random.Range(-9, -13), 0), Quaternion.identity);
    }
}
