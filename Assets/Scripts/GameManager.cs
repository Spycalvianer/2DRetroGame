using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    BuildingScript building;
    PlayerInput playerInput;
    CGPBoundsScript boundScript;
    SpawnClouds objectSpawned;
    SpawnAlcoholBottle alcoholBottleSpawn;
    SpawnWaterBottle waterBottleSpawn;
    UIHeight height;
    public SpawnPool pool;
    UIScore scoreUI;
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
        scoreUI = FindObjectOfType<UIScore>();
        building = FindObjectOfType<BuildingScript>();
    }
    void Update()
    {
        playerInput.GetInput();
        playerInput.Movement();
        boundScript.ApplyBounds();
        height.HeightMeassure();
        height.ConditionToSpawnPool();
        height.UpdateFallingImage();
        scoreUI.UpdateScoreText();
        building.MoveBuilding();
    }
}
