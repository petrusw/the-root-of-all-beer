using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRoomScript : MonoBehaviour
{
    public static CreateRoomScript Instance = new CreateRoomScript();

    public List<GameObject> Doors = new List<GameObject>(); // up = 0 , down = 1 , right = 2 , left = 3 

    public GameObject LevelGenerator;

    public Levelgenerator Levelgenerator;

    public GameObject Player;


    private void Start()
    {

        ClearDoors();

        CreateNextRoom(Levelgenerator.RoomNR);
    }

    private void ClearDoors()
    {
        foreach (var door in Doors)
        {
            door.SetActive(false);
        }
    }


    public void CreateNextRoom(int roomNumber)
    {
      
        // set player position
        if (Levelgenerator.RoomNR == 1)
        {
            Player.SetActive(true);
            Player.transform.position = new Vector3(0, -0.8f, 0);
            Doors[0].SetActive(true);

            
        }
        else
        {

            ClearDoors();
            // set doors that should be active
            foreach (var _room in LevelGenerator.GetComponent<LevelManager>().Generator.rooms)
            {
                if (_room.RoomNR == Levelgenerator.RoomNR)
                {
                    foreach (var _door in _room.Doors)
                    {
                        if (_door.DoorPlaceMent == DoorPlaceMent.Down)
                        {
                            Doors[1].SetActive(true);
                        }

                        if (_door.DoorPlaceMent == DoorPlaceMent.Up)
                        {
                            Doors[0].SetActive(true);
                        }

                        if (_door.DoorPlaceMent == DoorPlaceMent.Right)
                        {
                            Doors[2].SetActive(true);
                        }

                        if (_door.DoorPlaceMent == DoorPlaceMent.Left)
                        {
                            Doors[3].SetActive(true);
                        }
                    }
                }

            }
        }
        Levelgenerator.RoomNR++;
    }


}
