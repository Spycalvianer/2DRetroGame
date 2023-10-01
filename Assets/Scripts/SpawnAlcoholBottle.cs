using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAlcoholBottle : MonoBehaviour
{
    public GameObject cloudSpawned;
    private float timeBetweenSpawning;
    public IEnumerator TimerForSpawning()
    {
        while (true)
        {
            timeBetweenSpawning = Random.Range(2,5);
            yield return new WaitForSeconds(timeBetweenSpawning);
            Instantiatebottles();
        }
    }
    public void Instantiatebottles()
    {
        Instantiate(cloudSpawned, new Vector3(Random.Range(-10, 10), Random.Range(-9, -13), 0), Quaternion.identity);
    }
}
