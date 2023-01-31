using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MovementSpeed;
    public GameObject Sprite;
    public bool MoveRight, MoveLeft, MoveUp, MoveDown;
    // Start is called before the first frame update
    void Start()
    {
        MoveDown = true;
        MoveUp = true;
        MoveLeft = true;
        MoveRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // block direction if collided with object

        // block left
        if(MoveLeft == false)
        {
            if(horizontal < 0)
            {
                horizontal = 0;
            }
        }

        // block right
        if(MoveRight == false)
        {
            if(horizontal > 0)
            {
                horizontal = 0;
            }
        }

        // block up
        if(MoveUp == false)
        {
            if(vertical > 0)
            {
                vertical = 0;
            }
        }

        // block down
        if(MoveDown == false)
        {
            if(vertical < 0)
            {
                vertical = 0;
            }
        }




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
