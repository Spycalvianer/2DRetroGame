using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpeedSelector : MonoBehaviour
{
    public LevelPreferences levelPrefs;
    [SerializeField] EnemyMove movingEnemy;
    [SerializeField] ObjectMoveScript movingObject;
    int buildIndex;

    private void Start()
    {
        buildIndex = SceneManager.GetActiveScene().buildIndex;
        movingObject = GetComponent<ObjectMoveScript>();
        movingEnemy=GetComponent<EnemyMove>();
        if(buildIndex != 1)
        {
            if (movingEnemy != null)
            {
                movingEnemy.movingSpeed = 5f + (SceneManager.GetActiveScene().buildIndex * 2);
                movingEnemy.timeToDestroy = 5f;
            }
            else if (movingObject != null)
            {
                movingObject.movingSpeed = 5f + (SceneManager.GetActiveScene().buildIndex * 0.6f);
                movingObject.timeToDestroy = 5f;
            }
        }
        else if (movingEnemy != null)
        {
            movingEnemy.movingSpeed = 2f + (SceneManager.GetActiveScene().buildIndex);
            movingEnemy.timeToDestroy += SceneManager.GetActiveScene().buildIndex;
        }
        else if (movingObject != null)
        {
            movingObject.movingSpeed = 2f + (SceneManager.GetActiveScene().buildIndex);
            movingObject.timeToDestroy += SceneManager.GetActiveScene().buildIndex;
        }
    }
}
