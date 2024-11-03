using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CGPBoundsScript boundScript;
    SpawnClouds objectSpawned;
    SpawnAlcoholBottle alcoholBottleSpawn;
    SpawnWaterBottle waterBottleSpawn;
    public UIHeight height;
    public SpawnPool pool;
    public UIUpdater updateUI;
    public MovingFloor movingFloor;
    EnemySpawn enemySpawning;
    public PlayerData data;
    private void Start()
    {
        boundScript.GetCameraBounds();
        objectSpawned = GetComponent<SpawnClouds>();
        StartCoroutine(objectSpawned.TimerForSpawning());
        alcoholBottleSpawn = GetComponent<SpawnAlcoholBottle>();
        StartCoroutine(alcoholBottleSpawn.TimerForSpawning());
        waterBottleSpawn = GetComponent<SpawnWaterBottle>();
        StartCoroutine(waterBottleSpawn.TimerForSpawning());
        height.makePoolAppear += pool.PoolSpawn;
        height.StartingPosition();
        movingFloor = FindObjectOfType<MovingFloor>();
        enemySpawning = GetComponent<EnemySpawn>();
        StartCoroutine(enemySpawning.TimeForSpawning());
        data.SetStartingHealth();
        
    }
    void Update()
    {
        boundScript.ApplyBounds();
        height.HeightMeassure();
        height.ConditionToSpawnPool();
        height.UpdateFallingImage();
        updateUI.UpdateScoreText();
        if(height.spawnPool) movingFloor.MoveFloor();
        updateUI.UpdateHealthImage();
    }
}
