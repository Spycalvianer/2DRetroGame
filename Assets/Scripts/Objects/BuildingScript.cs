using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    Vector3 initialPosition = new Vector3(0, -11, 0);
    Vector3 finalPosition = new Vector3(0, 11, 0);
    [SerializeField] float buildingMovingSpeed;

    //-----New---------------
    [SerializeField] Transform target;
    [SerializeField] Transform spawner;

    private void Update()
    {
        //MoveBuilding();
        NewMoveBuilding();
    }
    private void MoveBuilding()
    {
        if (transform.position == finalPosition)
        {
            transform.position = initialPosition;
        }
        else transform.position = Vector3.MoveTowards(transform.position, finalPosition, Time.deltaTime * buildingMovingSpeed);
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
