using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float movingSpeed;
    private float timer = 0;
    public float timeToDestroy;
    private void Update()
    {
        MovingEnemy();
        DestroyObject();
    }
    void MovingEnemy()
    {
        transform.position += transform.localScale.x * movingSpeed * transform.right * Time.deltaTime;
    }
    void DestroyObject()
    {
        timer += Time.deltaTime;
        if (timer > timeToDestroy) Destroy(gameObject);
    }
}
