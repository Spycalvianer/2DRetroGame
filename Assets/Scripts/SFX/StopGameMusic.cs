using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGameMusic : MonoBehaviour
{
    [SerializeField] GameObject gameplayyMusic;

    public void StopMusic()
    {
        gameplayyMusic = FindObjectOfType<SFXScript>().gameObject;
        gameplayyMusic.SetActive(false);
    }
}
