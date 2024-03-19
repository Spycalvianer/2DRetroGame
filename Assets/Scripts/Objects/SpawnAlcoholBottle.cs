using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAlcoholBottle : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    private float timeBetweenSpawning;
    [SerializeField] float minRangeToSpawn, maxRangetoSpawn;
    public IEnumerator TimerForSpawning()
    {
        while (true)
        {
            timeBetweenSpawning = Random.Range(1,4);
            yield return new WaitForSeconds(timeBetweenSpawning);
            Instantiatebottles();
        }
    }
    public void Instantiatebottles()
    {
        Instantiate(ObjectToSpawn, new Vector3(Random.Range(minRangeToSpawn, maxRangetoSpawn),-13, 0), Quaternion.identity);
    }
}
