using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour
{
    [SerializeField] AudioSource sfx;
    public void PlayAudio()
    {
        sfx.Play();
    }
}
