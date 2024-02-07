using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioSource crashSound;
    public AudioSource poolLanding;
    public AudioSource waterBottle;
    public AudioSource beerCan;
    public void CrashSound()
    {
        crashSound.Play();
    }
    public void PoolLandingSound()
    {
        poolLanding.Play();
    }
    public void GrabWaterBottle()
    {
        waterBottle.Play();
    }
    public void GrabBeerCan()
    {
        beerCan.Play();
    }
}
