using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIHeight : MonoBehaviour
{
    public Image filledImage;
    public float defillingSpeed;
    public event Action makePoolAppear;
    public bool spawnPool = false;
    public Image fallingImage;
    public float YStart;
    public void HeightMeassure()
    {
        filledImage.fillAmount -= Time.deltaTime * defillingSpeed;
    }
    public void ConditionToSpawnPool()
    {
        if (!spawnPool && filledImage.fillAmount < 0.1f)
        {
            makePoolAppear?.Invoke();
            spawnPool = true;
        }
    }
    public void StartingPosition()
    {
        YStart = filledImage.fillAmount + filledImage.rectTransform.rect.height;
    }
    public void UpdateFallingImage()
    {
        fallingImage.transform.position = new Vector3(filledImage.transform.position.x, YStart * filledImage.fillAmount, 0);
    }
}
