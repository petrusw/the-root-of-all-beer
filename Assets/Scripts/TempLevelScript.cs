// the temporary levels for the ggj =>
// Level 1
// 
// Text block welkoming you to the dungeon.
// sequence one => wave of max 3 enemies.
// sequence 2 => wave of max 3 enemies.
// sequence 3 => wave of max 3 enemies.
// sequence 4 => 1 door that leads to level2.
//
// Level 2
//
// sequence one => wave of max 3 enemies.
// sequence 2 => wave of max 3 enemies.
// sequence 3 => wave of max 3 enemies.
// sequence 4 => 3 doors that leads to Level1 (down), level3 (left) and Level4 (right)
//
// Level 3
//
// sequence one => wave of max 5 enemies.
// sequence 2 => wave of max 5 enemies.
// sequence 3 => wave of max 4 enemies.
// sequence 4 => 2 doors that leads to Level2 (right), level5 (up)
//
// Level 4
//
// sequence one => wave of max 6 enemies.
// sequence 2 => wave of max 8 enemies.
// sequence 4 => 2 doors that leads to Level2 (left), level6 (Right) 
//
// Level 5
//
// sequence one => wave of max 2 enemies.
// sequence 2 => Small Boss
// sequence 4 => 2 doors that leads to Level3 (down), level7 (up)
//
// Level 6
//
// sequence one => wave of max 5 enemies.
// sequence 2 => wave of max 6 enemies.
// sequence 3 => wave of max 10 enemies.
// sequence 4 => 2 doors that leads to Level4 (left), level8 (up)
//
// Level 7
//
// sequence one => wave of max 10 enemies.
// sequence 2 => wave of max 3 enemies.
// sequence 3 => wave of max 9 enemies.
// sequence 4 => 2 doors that leads to Level5 (down), level8 (up)
//
// level 8
//
// sequence 1 => wave of 25 enemies
// sequence 2 => wave of 15 enemies
// sequence 3 => final boss
// sequence 4 => 1 door leads to the end sequence

using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class TempLevelScript : MonoBehaviour
{

    public List<GameObject> Doors;
    private int lenelNR;
    public GameObject Mainloop;

    private void Start()
    {
        lenelNR = 1; 
    }

    public void NextLevel(string doorname)
    {
        Mainloop.GetComponent<GameLoopScript>().DisableDoorSequence();
        doorname = doorname.ToLower();
        Debug.Log("---------------------------------------------------------------" + doorname);
        switch(lenelNR)
        {
            case 1:
                if(doorname.ToLower() == Doors[0].name.ToLower()) // up to level 2
                {
                    Doors[0].SetActive(false);//up
                    Doors[1].SetActive(true);//down
                    Doors[2].SetActive(true);//left
                    Doors[3].SetActive(true);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 5;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(5);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 2;
                }
                break;
            case 2:
                if (doorname.ToLower() == Doors[1].name.ToLower())//down to level 1
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 1;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(1);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 1;
                    break;
                }
                if (doorname.ToLower() == Doors[2].name.ToLower())//left to level 3
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(true);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 9;

                    Mainloop.GetComponent<GameLoopScript>().SetSequence(9);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 3;
                    break;
                }
                if (doorname.ToLower() == Doors[3].name.ToLower())//right to level 4
                {
                    Doors[0].SetActive(false);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(true);//left
                    Doors[3].SetActive(true);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 13;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(13);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 4;
                    break;
                }
                break;
            case 3:
                if (doorname.ToLower() == Doors[3].name.ToLower())//right to level 2
                {
                    Doors[0].SetActive(false);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(true);//left
                    Doors[3].SetActive(true);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 5;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(5);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 2;
                    break;
                }
                if (doorname == Doors[3].name.ToLower())//up to level 5
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(true);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 17;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(17);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 5;
                    break;
                }
                break;
            case 4:
                if (doorname == Doors[2].name.ToLower())//left to level 2
                {
                    Doors[0].SetActive(false);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(true);//left
                    Doors[3].SetActive(true);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 5;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(5);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 2;
                    break;
                }
                if (doorname == Doors[3].name.ToLower())//right to level 6
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(true);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 21;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(21);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 6;
                    break;
                }
                break;
            case 5:
                if (doorname == Doors[1].name.ToLower())//down to level 3
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(true);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 9;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(9);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 3;
                    break;
                }
                if (doorname == Doors[0].name.ToLower())//up to level 7
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(true);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 25;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(25);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    break;
                }
                break;
            case 6:
                if (doorname == Doors[2].name.ToLower())//left to level 4
                {
                    Doors[0].SetActive(false);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(true);//left
                    Doors[3].SetActive(true);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 5;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(5);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 4;
                    break;
                }
                if (doorname == Doors[0].name.ToLower())//up to level 8
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 29;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(29);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 8;
                    break;
                }
                break;
            case 7:
                if (doorname == Doors[1].name.ToLower())//down to level 5
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(true);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 5;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(5);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 5;
                    break;
                }
                if (doorname == Doors[0].name.ToLower())//up to level 8
                {
                    Doors[0].SetActive(true);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 29;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(29);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 8;
                    break;
                }
                break;
            case 8:
                if (doorname == Doors[0].name.ToLower())//up to level end
                {
                    Doors[0].SetActive(false);//up
                    Doors[1].SetActive(false);//down
                    Doors[2].SetActive(false);//left
                    Doors[3].SetActive(false);//right
                    Mainloop.GetComponent<GameLoopScript>().enemiesAlive = 0;
                    Mainloop.GetComponent<GameLoopScript>().sequenceNr = 33;
                    Mainloop.GetComponent<GameLoopScript>().SetSequence(33);
                    foreach (var d in Doors)
                    {
                        d.GetComponent<BoxCollider2D>().enabled = false;
                    }
                    lenelNR = 1;
                    break;
                }
                break;
        }
    }
}
