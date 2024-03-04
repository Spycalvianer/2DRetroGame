using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoses : MonoBehaviour
{
    PlayerData data;
    Canvas sceneCanvas;
    [SerializeField] GameObject losePanel;
    GameManager gameManager;
    BuildingScript[] buildings;
    ObjectMoveScript[] objects;
    EnemyMove[] enemies;
    GameObject music;
    private void Start()
    {
        data = GetComponent<PlayerData>();
    }
    private void Update()
    {
        if(data.health <= 0)
        {
            sceneCanvas = GameObject.Find("---UICanvas---").GetComponent<Canvas>();
            Instantiate(losePanel, sceneCanvas.transform);
            Time.timeScale = 0;
            gameManager = FindObjectOfType<GameManager>();
            buildings = FindObjectsOfType<BuildingScript>();
            objects = FindObjectsOfType<ObjectMoveScript>();
            enemies = FindObjectsOfType<EnemyMove>();
            music = GameObject.Find("Music");
            if(music != null) music.SetActive(false);
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i].buildingMovingSpeed = 0;
            }
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].movingSpeed = 0;
            }
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].movingSpeed = 0;
            }
            if (gameManager != null)
            {
                gameObject.SetActive(false);
                gameManager.gameObject.SetActive(false);
            }
        }
    }
}
