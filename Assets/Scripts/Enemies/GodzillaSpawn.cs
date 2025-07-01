using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodzillaSpawn : MonoBehaviour
{
    float timerForSpawning;
    Vector3 areaLeft, areaRight;
    public GameObject godzillaGO;
    int areaSelector;
    Vector3 areaToSpawn;
    [SerializeField] Animation godzillaAnim;

    private void Start()
    {
        StartCoroutine(TimerForGodzilla());
    }
    IEnumerator TimerForGodzilla()
    {
        while (true)
        {
            timerForSpawning = Random.Range(6, 12);
            yield return new WaitForSeconds(timerForSpawning);
            InstantiateGodzilla();
        }
    }
    public void DefineAreas()
    {
        areaLeft = new Vector3(-20, Random.Range(-4, -8), 0);
        areaRight = new Vector3(20, Random.Range(-4, -8), 0);
    }
    public void SelectAreaToSpawn()
    {
        areaSelector = Random.Range(1, 3);
        if (areaSelector == 1)
        {
            areaToSpawn = areaLeft;
            godzillaGO.transform.localScale = new Vector3(1, 1, 1);
        }
        else if (areaSelector == 2)
        {
            areaToSpawn = areaRight;
            godzillaGO.transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    public void InstantiateGodzilla()
    {
        DefineAreas();
        SelectAreaToSpawn();
        Instantiate(godzillaGO, areaToSpawn, Quaternion.identity);
        godzillaAnim.Play();
    }
}
