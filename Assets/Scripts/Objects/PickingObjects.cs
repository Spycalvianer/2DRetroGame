using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickingObjects : MonoBehaviour
{
    PickUpScore pikupscore;
    [SerializeField] GameObject pickUpTextGO;
    public PickableObjects bottleScore;
    PlayerData playerDayta;
    public float scoreToAdd;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            playerDayta = collision.GetComponent<PlayerData>();
            scoreToAdd = (bottleScore.gainedPoints - bottleScore.damagePoints) * SceneManager.GetActiveScene().buildIndex;
            playerDayta.score += scoreToAdd;
            playerDayta.UpdateHealth(-bottleScore.healthPoints);
            Instantiate(pickUpTextGO, transform.position, Quaternion.identity);
            pikupscore = FindObjectOfType<PickUpScore>();
            pikupscore.ShowScore(scoreToAdd);
            Destroy(gameObject);
        }
    }
}
