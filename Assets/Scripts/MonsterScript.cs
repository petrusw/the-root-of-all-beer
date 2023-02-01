using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    public float life;
    public float damage;
    public float Speed;
    public int Points;
    public GameObject Lifebar;
    public Transform playerPosition;


    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 oldPosition = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, Speed * Time.deltaTime);
        if(transform.position.x > oldPosition.x)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }


        Lifebar.transform.localScale = new Vector3(life / 500, Lifebar.transform.localScale.y, Lifebar.transform.localScale.z);


    }
}
