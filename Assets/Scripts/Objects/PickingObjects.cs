using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickingObjects : MonoBehaviour
{
    public PickableObjects bottleScore;
    PlayerData playerDayta;
    [SerializeField] float scoreMultiplier;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerDayta = collision.GetComponent<PlayerData>();
            playerDayta.score += (bottleScore.gainedPoints - bottleScore.damagePoints) * SceneManager.GetActiveScene().buildIndex;
            playerDayta.UpdateHealth(-bottleScore.healthPoints);
            Destroy(gameObject);
        }
    }
}
