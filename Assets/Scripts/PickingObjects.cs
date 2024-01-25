using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickingObjects : MonoBehaviour
{
    public PickableObjects bottleScore;
    PlayerData playerDayta;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerDayta = collision.GetComponent<PlayerData>();
            playerDayta.score += bottleScore.gainedPoints - bottleScore.damagePoints;
            Destroy(gameObject);
        }
    }
}
