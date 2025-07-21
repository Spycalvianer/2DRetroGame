using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlaneThrowingBomb : MonoBehaviour
{
    [SerializeField] GameObject bombObj;
    IEnumerator BombTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            BombThrowing();
        }
    }
    private void Start()
    {
        StartCoroutine(BombTimer());
    }
    void BombThrowing()
    {
        Instantiate(bombObj, transform.position, Quaternion.identity);
    }
}
