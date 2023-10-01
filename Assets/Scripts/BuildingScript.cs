using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    Vector3 initialPosition = new Vector3(0, -1, 0);
    Vector3 finalPosition = new Vector3(0, 1f, 0);
    public float buildingMovingSpeed;

    public void MoveBuilding()
    {
        if (transform.position == finalPosition)
        {
            transform.position = initialPosition;
        }
        else transform.position = Vector3.MoveTowards(transform.position, finalPosition, Time.deltaTime * buildingMovingSpeed);
    }
}
