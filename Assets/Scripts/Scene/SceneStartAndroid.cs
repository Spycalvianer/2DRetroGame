using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStartAndroid : MonoBehaviour
{
    Animator playerAnimator;
    GameObject gamemanager;
    private void Update()
    {
        SceneStart();
    }
    void SceneStart()
    {
        if (Input.touchCount == 2)
        {
            Touch touch = Input.GetTouch(2);
            if (touch.phase == TouchPhase.Began)
            {
                playerAnimator.SetTrigger("Jump");
                gamemanager.SetActive(true);
            }
        }
    }
}
