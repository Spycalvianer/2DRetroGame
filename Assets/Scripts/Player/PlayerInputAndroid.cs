using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputAndroid : MonoBehaviour
{
    public GameObject playerGO;
    public Rigidbody2D rb;
    public float speed;
    Vector3 position;

    private void Update()
    {
        GameplayInput();
    }
    void GameplayInput()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {/*
                Vector2 deltaPosition = touch.deltaPosition;
                deltaPosition.x = deltaPosition.x - Screen.width;
                deltaPosition.y = deltaPosition.y - Screen.height;
                Vector2 normalizedPosition = new Vector2(deltaPosition.x, deltaPosition.y);
                speed = touch.deltaPosition.magnitude;
                Vector2 movement = normalizedPosition * speed * Time.deltaTime;
                playerGO.transform.position += new Vector3 (movement.x, movement.y, 0);
                */
                playerGO.transform.position = new Vector3(playerGO.transform.position.x + touch.deltaPosition.x * speed, playerGO.transform.position.y + touch.deltaPosition.y * speed, playerGO.transform.position.z);
                /*
                Vector2 pos = touch.position;
                pos.x = (pos.x - Screen.width/2)/ Screen.width/2;
                pos.y = (pos.y - Screen.height/2)/ Screen.height/2;
                position = new Vector3(pos.x, pos.y, 0);
                playerGO.transform.position += position * speed;
                */
            }
        }
    }
}
