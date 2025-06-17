using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodzillaSpawn : MonoBehaviour
{
    Vector3 areaLeft, areaRight;
    public GameObject godzillaGO;
    int areaSelector;
    Vector3 areaToSpawn;

    private void Start()
    {
        areaLeft = new Vector3(-13, Random.Range(4, -4), 0);
        areaRight = new Vector3(15, Random.Range(4, -4), 0);
    }
    public void SelectAreaToSpawnAndInstantiate()
    {
        areaSelector = Random.Range(1, 3);
        if (areaSelector == 1)
        {
            areaToSpawn = areaLeft;
            InstantiateGodzilla();
            godzillaGO.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (areaSelector == 2)
        {
            areaToSpawn = areaRight;
            InstantiateGodzilla();
            godzillaGO.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    public void InstantiateGodzilla()
    {
        Instantiate(godzillaGO, areaToSpawn, Quaternion.identity);
    }
}
