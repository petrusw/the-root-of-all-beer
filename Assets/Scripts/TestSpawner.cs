using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawner : MonoBehaviour
{
    public List<GameObject> gameObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
       //GameObject obj = Instantiate(gameObjects[0]);
       // obj.transform.position = new Vector3(1, -2, 1);
       // obj.SetActive(true);

        for(var i = 0; i < gameObjects.Count; i++)
        {
            spawn(i);
        }
    }

   private void spawn(int nr)
    {
        GameObject obj = Instantiate(gameObjects[nr]);
        obj.transform.position = new Vector3(1, -2, 1);
        obj.SetActive(true);
    }
}
