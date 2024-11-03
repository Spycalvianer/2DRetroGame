using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAspectRatio : MonoBehaviour
{
    public Renderer modelRenderer;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        ChangeModelRatio();
    }
    void ChangeModelRatio()
    {
        if(modelRenderer  != null) transform.localScale = new Vector3((float)Screen.width / Screen.height / modelRenderer.bounds.size.x, transform.localScale.y, transform.localScale.z);
    }
   }
