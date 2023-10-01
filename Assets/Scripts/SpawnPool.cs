using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPool : MonoBehaviour
{
    public GameObject pool;
    public void PoolSpawn()
    {
        Instantiate(pool, new Vector3(0, -18, 0), Quaternion.identity);
    }
}
