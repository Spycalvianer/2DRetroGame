using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMultipleEnemies : MonoBehaviour
{
    [SerializeField] GameObject[] enemies;
    float timerToSpawn;
    int enemySelector;
    Vector3 areaRight;
    Vector3 areaLeft;
    int arearSelector;
    Vector3 areaToSpawn;
    public IEnumerator EnemyTimer()
    {
        while (true)
        {
            timerToSpawn = Random.Range(3, 6);
            yield return new WaitForSeconds(timerToSpawn);
            InstantiateEnemiesArray();
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
        areaRight = new Vector3(Random.Range(20, 15), Random.Range(-4, 5), 0);
        areaLeft = new Vector3(Random.Range(-20, -15), Random.Range(5, -4), 0);
    }
    void SelectEnemy()
    {
        enemySelector = Random.Range(0, enemies.Length);
    }
    void InstantiateEnemiesArray()
    {
        if (enemies.Length > 0)
        {
            DefineAreaToSpawn();
            SelectAreaToSpawn();
            SelectEnemy();
            if (arearSelector == 1) enemies[enemySelector].transform.localScale = new Vector3(-1, 1, 1);
            else if (arearSelector == 2) enemies[enemySelector].transform.localScale = new Vector3(1, 1, 1);
            Instantiate(enemies[enemySelector], areaToSpawn,Quaternion.identity);
        }
    }
}
