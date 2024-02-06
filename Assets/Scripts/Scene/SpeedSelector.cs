using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpeedSelector : MonoBehaviour
{
    public LevelPreferences levelPrefs;
    [SerializeField] float additionalSpeed;
    [SerializeField] EnemyMove movingEnemy;
    [SerializeField] ObjectMoveScript movingObject;

    private void Start()
    {
        movingObject = GetComponent<ObjectMoveScript>();
        movingEnemy=GetComponent<EnemyMove>();
        if (movingEnemy != null)
        {
            movingEnemy.movingSpeed = 5f + (SceneManager.GetActiveScene().buildIndex + 1) * levelPrefs.speedFactor;
        }
        else if (movingObject != null)
        {
            movingObject.movingSpeed = 5f + SceneManager.GetActiveScene().buildIndex - 0.5f;
        }
    }
}
