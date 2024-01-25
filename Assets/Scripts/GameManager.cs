using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    PlayerInput playerInput;
    CGPBoundsScript boundScript;
    SpawnClouds objectSpawned;
    SpawnAlcoholBottle alcoholBottleSpawn;
    SpawnWaterBottle waterBottleSpawn;
    UIHeight height;
    public SpawnPool pool;
    UIUpdater updateUI;
    MovingFloor movingFloor;
    EnemySpawn enemySpawning;
    PlayerData data;
    SceneChangingScript sceneManager;
    private void Start()
    {
        playerInput = FindObjectOfType<PlayerInput>();
        boundScript = FindObjectOfType<CGPBoundsScript>();
        boundScript.GetCameraBounds();
        objectSpawned = GetComponent<SpawnClouds>();
        StartCoroutine(objectSpawned.TimerForSpawning());
        alcoholBottleSpawn = GetComponent<SpawnAlcoholBottle>();
        StartCoroutine(alcoholBottleSpawn.TimerForSpawning());
        waterBottleSpawn = GetComponent<SpawnWaterBottle>();
        StartCoroutine(waterBottleSpawn.TimerForSpawning());
        height = FindObjectOfType<UIHeight>();
        height.makePoolAppear += pool.PoolSpawn;
        height.StartingPosition();
        updateUI = FindObjectOfType<UIUpdater>();
        movingFloor = FindObjectOfType<MovingFloor>();
        enemySpawning = GetComponent<EnemySpawn>();
        StartCoroutine(enemySpawning.TimeForSpawning());
        data = FindObjectOfType<PlayerData>();
        data.SetStartingHealth();
        sceneManager = FindObjectOfType<SceneChangingScript>();
    }
    void Update()
    {
        playerInput.GetInput();
        playerInput.Movement();
        boundScript.ApplyBounds();
        height.HeightMeassure();
        height.ConditionToSpawnPool();
        height.UpdateFallingImage();
        updateUI.UpdateScoreText();
        if(height.spawnPool) movingFloor.MoveFloor();
        updateUI.UpdateHealthImage();
        if (data.health <= 0) sceneManager.ChangeScene("LoseScene");
    }
}
