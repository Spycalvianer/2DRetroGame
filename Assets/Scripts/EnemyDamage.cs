using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    PlayerData data;
    public int damage;
    [SerializeField] GameObject crashObjet;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Instantiate(crashObjet, transform.position, Quaternion.identity, null);
            data = collision.GetComponent<PlayerData>();
            data.UpdateHealth(damage);
        }
    }
}
