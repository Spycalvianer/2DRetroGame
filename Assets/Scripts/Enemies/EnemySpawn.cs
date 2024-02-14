using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    Vector3 areaRight;
    Vector3 areaLeft; 
    float timeBetweenSpawning;
    public GameObject enemy;
    int arearSelector;
    Vector3 areaToSpawn;
    
    public IEnumerator TimeForSpawning()
    {
        while (true)
        {
            timeBetweenSpawning = Random.Range(1, 6);
            yield return new WaitForSeconds(timeBetweenSpawning);
            InstantiateEnemies();
        }
    }
    void SelectAreaToSpawn()
    {
        arearSelector = Random.Range(1, 3);
        if (arearSelector == 1) areaToSpawn = areaRight;
        else if (arearSelector == 2) areaToSpawn = areaLeft;
    }
    void DefineAreaToSpawn()
    {
        areaRight = new Vector3(Random.Range(12, 15), Random.Range(-4, 5), 0);
        areaLeft = new Vector3(Random.Range(-12, -15), Random.Range(5, -4), 0);
    }
    void InstantiateEnemies()
    {
        if(enemy != null)
        {
            DefineAreaToSpawn();
            SelectAreaToSpawn();
            if (arearSelector == 1) enemy.transform.localScale = new Vector3(-1, 1, 1);
            else if (arearSelector == 2) enemy.transform.localScale = new Vector3(1, 1, 1);
            Instantiate(enemy, areaToSpawn, Quaternion.identity);
        }
    }
}