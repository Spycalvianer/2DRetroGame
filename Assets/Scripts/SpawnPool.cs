using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPool : MonoBehaviour
{
    public GameObject pool;
    public Transform floor;
    public float minSpawnPool;
    public float maxSpawnPool;
    public float yDistance;
    public void PoolSpawn()
    {
        Instantiate(pool, transform.position = new Vector3(Random.Range(minSpawnPool,maxSpawnPool), yDistance, 0), Quaternion.identity, floor);
    }
}
