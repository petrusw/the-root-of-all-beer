using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelgenerator : MonoBehaviour
{
    [SerializeField]
    private int NrOfRooms;

    public List<Room> rooms = new List<Room>();

    public int RoomNR;

    private int TotalCreatedRooms;
    // Start is called before the first frame update
    void Start()
    {
       CreateRooms();
    }

   public void CreateRooms()
    {
        Debug.Log("-------------------------------------------------------------------------------");
        // set the number of levels
        int _levels = Random.Range(2, 5); Debug.Log("total levels: " + _levels);

        // set the number of total rooms
        NrOfRooms = Random.Range(10, 50);Debug.Log("total number of rooms: " + NrOfRooms);

        Debug.Log("-------------------------------------------------------------------------------");
        // start the room generating loop
        for (var i = 0; i<_levels;i++)
        {
            // set level start
            if(i == 0)
            {
                // create new room
                var _startroom = new Room();

                // create new door
                var _door = new Door();

                // set door
                _startroom.Doors.Add(_door);

                // set the placement for the door
                _startroom.Doors[0].DoorPlaceMent = DoorPlaceMent.Up;

                //set the door to closed
                _startroom.Doors[0].IsOpen = false;

                //Set the connecting room nr
                _startroom.Doors[0].ConnectingRoom = 2;

                // set the number of doors
                _startroom.NumberOfDoors = 1;

                // set the roomtype
                _startroom.RoomType = RoomType.Start;

                // set the roomNR
                _startroom.RoomNR = 1;

                //set the total of created rooms
                TotalCreatedRooms = 1;

                // add room to list
                rooms.Add(_startroom);
                Debug.Log("-------------------------------------------------------------------------------");
                Debug.Log("Start room: " + _startroom.RoomNR + " connecting room: " + _startroom.Doors[0].ConnectingRoom + " placement: " + _startroom.Doors[0].DoorPlaceMent);
                Debug.Log("total created rooms: " + TotalCreatedRooms);
                Debug.Log("-------------------------------------------------------------------------------");
            }


            // set endboss level
            if (i == _levels -1)
            {
                // create new room
                Room _endroom = new Room();

                // create new door
                Door _door = new Door();

                // set door
                _endroom.Doors.Add(_door);

                // set the placement for the door
                _endroom.Doors[0].DoorPlaceMent = DoorPlaceMent.Down;

                //set the door to closed
                _endroom.Doors[0].IsOpen = false;

                // set the number of doors
                _endroom.NumberOfDoors = 1;

                // set the roomtype
                _endroom.RoomType = RoomType.End;

                // add room to list
                rooms.Add(_endroom);

                // set the roomNR
                _endroom.RoomNR = NrOfRooms;
                Debug.Log("-------------------------------------------------------------------------------");
                Debug.Log("end room: " + _endroom.RoomNR + " connecting room: " + _endroom.Doors[0].ConnectingRoom + " placement: " + _endroom.Doors[0].DoorPlaceMent);
                Debug.Log("total created rooms: " + TotalCreatedRooms);
                Debug.Log("-------------------------------------------------------------------------------");
                // the connecting room must be set when the room is generated!!!!!
            }


            // set second level
            if(i > 0 && i < 2)
            {
                // start the level generating for the second level
                var _room = new Room();

                //create the start door
                var _stDoor = new Door();

                // set the connecting room
                _stDoor.ConnectingRoom = 1;

                // set the placement
                _stDoor.DoorPlaceMent = DoorPlaceMent.Down;

                // set the door open
                _stDoor.IsOpen = true;

                _room.Doors.Add(_stDoor);

                _room.RoomType = RoomType.Normal;

                TotalCreatedRooms++;
                _room.RoomNR = TotalCreatedRooms;



                // create random doors
                var totaldoorscreated = 0;

               
                    
                    // left door
                    var _createOrNot = Random.Range(0, 2);

                    if (_createOrNot == 1)
                    {
                        // create the left door 
                        var _door = new Door();

                        // set the placement to left
                        _door.DoorPlaceMent = DoorPlaceMent.Left;

                        // set the connecting room
                        TotalCreatedRooms++;
                        _door.ConnectingRoom = TotalCreatedRooms;

                        _door.IsOpen = false;

                        //add the door to the list
                        _room.Doors.Add(_door);
                        totaldoorscreated++;
                    }

                    // top door
                    if(_createOrNot == 0)
                     {
                           _createOrNot = 1;
                     }
                      else
                       {
                          _createOrNot = Random.Range(0, 2);
                      }

                    if (_createOrNot == 1)
                    {
                        // create the left door 
                        var _door = new Door();

                        // set the placement to left
                        _door.DoorPlaceMent = DoorPlaceMent.Up;

                        // set the connecting room
                        TotalCreatedRooms++;
                        _door.ConnectingRoom = TotalCreatedRooms;

                        _door.IsOpen = false;
                        //add the door to the list
                        _room.Doors.Add(_door);
                        totaldoorscreated++;
                    }
                    // right door
                    _createOrNot = Random.Range(0, 2);

                    if (_createOrNot == 1)
                    {
                        // create the left door 
                        var _door = new Door();

                        // set the placement to left
                        _door.DoorPlaceMent = DoorPlaceMent.Right;

                        // set the connecting room
                        TotalCreatedRooms++;
                        _door.ConnectingRoom = TotalCreatedRooms;

                        _door.IsOpen = false;
                        //add the door to the list
                        _room.Doors.Add(_door);
                        totaldoorscreated++;
                    }
                
                rooms.Add(_room);


                Debug.Log("-------------------------------------------------------------------------------");
                Debug.Log(" room: " + _room.RoomNR);
                foreach(var d in _room.Doors)
                {
                    Debug.Log(" connecting room: " + d.ConnectingRoom + " placement: " + d.DoorPlaceMent);
                }
                Debug.Log("total created rooms: " + TotalCreatedRooms);
                Debug.Log("-------------------------------------------------------------------------------");

               

            }
           
            
            // create rooms folowing the doors in the room
            if (i > 1)
            {
                foreach (var d in rooms[1].Doors)
                {
                    if (d.ConnectingRoom != 1)
                    {
                        // start the level generating for the second level
                        var _newroom = new Room();

                        //create the start door
                        var _Door = new Door();

                        // set the connecting room
                        _Door.ConnectingRoom = 1;

                        // set the placement
                        _Door.DoorPlaceMent = DoorPlaceMent.Down;

                        // set the door open
                        _Door.IsOpen = true;

                        rooms[1].Doors.Add(_Door);

                        _newroom.RoomType = RoomType.Normal;

                        TotalCreatedRooms++;
                        _newroom.RoomNR = TotalCreatedRooms;

                        Debug.Log("-------------------------------------------------------------------------------");
                        Debug.Log(" room: " + rooms[1].RoomNR);
                        foreach (var _d in _newroom.Doors)
                        {
                            Debug.Log(" connecting room: " + d.ConnectingRoom + " placement: " + d.DoorPlaceMent);
                        }
                        Debug.Log("total created rooms: " + TotalCreatedRooms);
                        Debug.Log("-------------------------------------------------------------------------------");
                    }
                }







            }




        }



      
    }
}
public class Room
{
    public List<Door> Doors = new List<Door>();
    public int NumberOfDoors;
    public RoomType RoomType;
    public int RoomNR;
}
public class Door
{
    public DoorPlaceMent DoorPlaceMent;
    public int ConnectingRoom;
    public bool IsOpen;
}

public enum RoomType
{
    Start,
    Normal,
    Boss,
    End
}
public enum DoorPlaceMent
{
    Up,
    Down,
    Left,
    Right
}