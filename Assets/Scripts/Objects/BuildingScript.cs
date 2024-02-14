using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    public float buildingMovingSpeed;

    [SerializeField] Transform target;
    [SerializeField] Transform spawner;
    private void Update()
    {
        NewMoveBuilding();
    }
    void NewMoveBuilding()
    {
        if (transform.position.y == target.position.y)
        {
            transform.position = spawner.position;
        }
        else transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * buildingMovingSpeed);
    }
}
