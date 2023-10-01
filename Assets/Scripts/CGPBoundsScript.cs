using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGPBoundsScript : MonoBehaviour
{
    private Camera mainCamera;
    [HideInInspector] public Vector2 viewportMin;
    [HideInInspector] public Vector2 viewportMax;

    public void GetCameraBounds()
    {
        mainCamera = Camera.main;
        CalculateViewportBounds();
    }
    private void CalculateViewportBounds()
    {
        viewportMin = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
        viewportMax = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));
    }
    public void ApplyBounds()
    {
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, viewportMin.x, viewportMax.x);
        newPosition.y = Mathf.Clamp(newPosition.y, viewportMin.y, viewportMax.y);
        transform.position = newPosition;
    }
}
