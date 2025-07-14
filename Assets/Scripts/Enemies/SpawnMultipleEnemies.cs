using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMultipleEnemies : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    [SerializeField] float timerToSpawn;
    int enemySelector;

    public IEnumerator EnemyTimer()
    {
        while (true)
        {
            timerToSpawn = Random.Range(3, 8);
            yield return new WaitForSeconds(timerToSpawn);
            InstantiateEnemiesArray();
        }
    }
    void InstantiateEnemiesArray()
    {

    }
}
