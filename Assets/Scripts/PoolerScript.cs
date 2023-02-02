using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolerScript : MonoBehaviour
{
    public static PoolerScript Instance = new PoolerScript();
    public List<GameObject> PoolObjects = new List<GameObject>();
    public List<GameObject> StartObjects = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        foreach(var obj in StartObjects)
        {
             PoolObjects.Add(obj);
            Instantiate(obj);

            obj.SetActive(false);
           
        }
    }

    public GameObject SpawnFromPooler(GameObject Object)
    {
        foreach(var _obj in PoolObjects)
        {
            if (_obj.activeSelf == false)
            {
                if (_obj.name == Object.name + "(Clone)")
                {
                    return _obj;
                }
            }
        }
        GameObject newObject = Instantiate(Object);
        //PoolObjects.Add(newObject);
        newObject.SetActive(false);

        return newObject;
    }
}
