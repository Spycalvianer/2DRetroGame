using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpeedSelector : MonoBehaviour
{
    public LevelPreferences levelPrefs;
    EnemyMove movingEnemy;
    ObjectMoveScript movingObject;

    private void Start()
    {
        movingEnemy = GetComponent<EnemyMove>();
        movingObject = GetComponent<ObjectMoveScript>();

            if (movingEnemy != null)
            {
                movingEnemy.movingSpeed += SceneManager.GetActiveScene().buildIndex + 1;
            }
            else if (movingObject != null)
            {
                movingObject.movingSpeed += SceneManager.GetActiveScene().buildIndex - 0.5f;
            }
    }
}
