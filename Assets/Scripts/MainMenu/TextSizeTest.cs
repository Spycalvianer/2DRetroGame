using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextSizeTest : MonoBehaviour
{
    public Text text;
    public int multiplier;
    private void Update()
    {
        text.fontSize = (Screen.width - Screen.height)/multiplier;
    }
}
