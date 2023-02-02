using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public int health;
    public int XP;
    public GameObject player;


    private void Start()
    {
        player = GameObject.Find("Player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.name == "Player")
        {
            collision.collider.gameObject.GetComponent<PlayerStats>().XP += XP;

            collision.collider.gameObject.GetComponent<PlayerStats>().health += health;

            if(collision.collider.gameObject.GetComponent<PlayerStats>().health > 100)
            {
                collision.collider.gameObject.GetComponent<PlayerStats>().health = 100;
            }

            this.gameObject.SetActive(false);
        }
    }

}
