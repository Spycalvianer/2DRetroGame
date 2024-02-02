using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveScript : MonoBehaviour
{
    public float movingSpeed;
    private float timer = 0;
    public float timeToDestroy;
    private void Update()
    {
        MoveObject();
        DestroySpawnedObject();
    }
    public void MoveObject()
    {
        transform.position += transform.up * Time.deltaTime * movingSpeed;
    }
    public void DestroySpawnedObject()
    {
        timer += Time.deltaTime;
        if (timer > timeToDestroy) Destroy(gameObject);
    }
}
