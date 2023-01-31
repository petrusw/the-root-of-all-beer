using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed;
    public GameObject Sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontal, vertical, 0);
        transform.position += movementDirection * Time.deltaTime * MovementSpeed;


        if(horizontal < -0.01f)
        {
            Sprite.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (horizontal > 0.01f)
        {
            Sprite.GetComponent<SpriteRenderer>().flipX = true;
        }


    }
}
