using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public float life;
    public int damage;
    public float Speed;
    public int Points;
    public GameObject Lifebar;
    public Transform playerPosition;
    public int XP;
    public int damageByPlayer;

    private float _life;

    private bool direction;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").transform;
        _life = life;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name == "Player")
        {
            collision.collider.gameObject.GetComponent<PlayerStats>().health -= damage;

        }

        if (collision.collider.gameObject.name == "armLeft" || collision.collider.gameObject.name == "armRight")
        {
            playerPosition.gameObject.GetComponent<PlayerStats>().XP += XP;
            _life -= damageByPlayer;
            collision.collider.gameObject.GetComponent<Animator>().StopPlayback();

            collision.collider.gameObject.GetComponent<BoxCollider2D>().enabled = false;

            if(direction == false)
            {
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
            }


        }
    }

    private void OnDestroy()
    {
        GameLoopScript.Instance.enemiesAlive -= 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(playerPosition == null)
        {
            playerPosition = GameObject.Find("Player").transform;
        }

        Vector3 oldPosition = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, Speed * Time.deltaTime);
        if(transform.position.x > oldPosition.x)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
            direction = true;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
            direction = false;
        }


        Lifebar.transform.localScale = new Vector3(_life / 500, Lifebar.transform.localScale.y, Lifebar.transform.localScale.z);

        if (_life <= 0)
        {
            this.gameObject.SetActive(false);
            Destroy(gameObject);
        }

    }
}
