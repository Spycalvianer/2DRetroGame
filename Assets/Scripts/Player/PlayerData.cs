using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public float score;
    public float maxHealth;
    public float health;
    public void SetStartingHealth()
    {
        health = maxHealth;
    }
    public void UpdateHealth(float damage)
    {
        if (health <= maxHealth)
        {
            health -= damage;
        }
        else if ( health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
