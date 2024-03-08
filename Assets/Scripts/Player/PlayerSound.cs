using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] Animator playerAnimator;
    [SerializeField] AudioSource beerSound, waterSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Beer")
        {
            beerSound.Play();
            playerAnimator.SetTrigger("Drink");
        }
        else if(collision.tag == "Water")
        {
            playerAnimator.SetTrigger("Water");
            waterSound.Play();
        }
        else if(collision.tag == "Enemy")
        {
            playerAnimator.SetTrigger("P_Damage");
        }
    }
}
