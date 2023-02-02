using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    float timer;
    [SerializeField]
    private float time;

    public List<GameObject> gameObjects = new List<GameObject>();

    // Update is called once per frame


    private void Awake()
    {
        Invoke("spawn()", 0.5f);
    }

 

    void Update()
    {
        time += Time.deltaTime;
        if(time >= timer)
        {
            spawn();
        }
    }

    private void spawn()
    {
        var _object = PoolerScript.Instance.SpawnFromPooler(gameObjects[0]);
        _object.SetActive(true);
        _object.transform.position = new Vector3(0, -2.5f, 0);
        time = 0;
    }
}
