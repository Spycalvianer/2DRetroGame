using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] AudioSource beerSound, waterSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Beer")
        {
            beerSound.Play();
        }
        else if(collision.tag == "Water")
        {
            waterSound.Play();
        }
    }
}
