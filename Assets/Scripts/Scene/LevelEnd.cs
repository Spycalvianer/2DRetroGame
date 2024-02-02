using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject splashObject;
    public MovingFloor floor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            floor = FindObjectOfType<MovingFloor>();
            floor.movingSpeedUpwards = 0;
            collision.gameObject.SetActive(false);
            Instantiate(splashObject, collision.transform.position, Quaternion.identity);    
        }
    }
}
