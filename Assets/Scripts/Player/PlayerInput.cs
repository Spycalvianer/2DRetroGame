using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject playerGO;
    float xAxis;
    float yAxis;
    public float horizontalMoveSpeed;
    public float verticalMoveSpeed;
    Vector3 movementVector;

    Vector2 viewportMin;
    Vector2 viewportMax;

    Camera mainCamera;
    [SerializeField] GameObject pausePanel;
    public void GetInput()
    {
        xAxis = Input.GetAxis("Horizontal");
        yAxis = Input.GetAxis("Vertical");
        mainCamera = Camera.main;
    }
    public void Movement()
    {
        movementVector = new Vector3(xAxis * horizontalMoveSpeed, yAxis * verticalMoveSpeed, 0);
        playerGO.transform.position += movementVector * Time.deltaTime;
    }
    public void OpenPauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausePanel.SetActive(!pausePanel.activeSelf);
        }
    }
    public void TimescaleController()
    {
        if (pausePanel.activeSelf == true)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1f;
    }
    public void CalculateBounds()
    {
        viewportMax = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));
        viewportMin = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
    }
    public void ApplyBounds()
    {
        Vector3 newPosition = playerGO.transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, viewportMin.x, viewportMax.x);
        newPosition.y = Mathf.Clamp(newPosition.y, viewportMin.y, viewportMax.y);
        playerGO.transform.position = newPosition;
    }
}
