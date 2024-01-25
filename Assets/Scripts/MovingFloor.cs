using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloor : MonoBehaviour
{
    public float movingSpeedUpwards;
    public void MoveFloor()
    {
        transform.position += transform.up * movingSpeedUpwards * Time.deltaTime;
    }
}
