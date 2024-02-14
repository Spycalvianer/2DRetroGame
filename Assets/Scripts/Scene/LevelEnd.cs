using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public GameObject splashObject;
    public MovingFloor floor;
    GameManager gameManager;
    BuildingScript[] buildings;
    ObjectMoveScript[] objects;
    EnemyMove[] enemies;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            floor = FindObjectOfType<MovingFloor>();
            gameManager = FindObjectOfType<GameManager>();
            buildings = FindObjectsOfType<BuildingScript>();
            objects = FindObjectsOfType<ObjectMoveScript>();
            enemies = FindObjectsOfType<EnemyMove>();
            floor.movingSpeedUpwards = 0;
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i].buildingMovingSpeed = 0;
            }
            for(int i = 0; i<objects.Length; i++)
            {
                objects[i].movingSpeed = 0;
            }
            for(int i = 0; i < enemies.Length; i++)
            {
                enemies[i].movingSpeed = 0;
            }
            collision.gameObject.SetActive(false);
            gameManager.gameObject.SetActive(false);
            Instantiate(splashObject, collision.transform.position, Quaternion.identity);    
        }
    }
}
