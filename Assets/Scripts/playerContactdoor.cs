


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerContactdoor : MonoBehaviour
{
    public List<GameObject> Doors;
    public List<GameObject> DoorPositions;
    public GameObject MainGameLoop;
    public GameObject Levelgenerator;
    // Start is called before the first frame update
   private void NextLevel( string doorname)
    {
        // the level generator has a bug !! do not use!
        //Levelgenerator.GetComponent<Levelgenerator>().RoomNR += 1;

        //temporary fixed levels for the ggj

        MainGameLoop.GetComponent<TempLevelScript>().NextLevel(doorname);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("------cPlayerCollider------------- =>" + collision.gameObject.name );
        if(collision.gameObject.name == "DoorUP")
        {
            gameObject.transform.position = DoorPositions[1].transform.position;
            MainGameLoop.GetComponent<GameLoopScript>().enemiesAlive = 0;
            NextLevel(collision.gameObject.name);
            Debug.Log("------DoorUp------------- " );
        }
        if (collision.gameObject.name == "DoorDown")
        {
            gameObject.transform.position = DoorPositions[0].transform.position;
            MainGameLoop.GetComponent<GameLoopScript>().enemiesAlive = 0;
            NextLevel(collision.gameObject.name);
            Debug.Log("------DoorDown------------- ");
        }
        if (collision.gameObject.name == "Doorleft")
        {
            gameObject.transform.position = DoorPositions[3].transform.position;
            MainGameLoop.GetComponent<GameLoopScript>().enemiesAlive = 0;
            NextLevel(collision.gameObject.name);
            Debug.Log("------DoorLeft------------- ");
        }
        if (collision.gameObject.name == "Doorright")
        {
            gameObject.transform.position = DoorPositions[2].transform.position;
            MainGameLoop.GetComponent<GameLoopScript>().enemiesAlive = 0;
            NextLevel(collision.gameObject.name);
            Debug.Log("------DoorRight------------- ");
        }
    }
}
