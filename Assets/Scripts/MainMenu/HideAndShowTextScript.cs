using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndShowTextScript : MonoBehaviour
{
    public void HideShowText()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
