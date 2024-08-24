using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;

    int index;
    Vector2 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = new Vector2(0, 6);
        InvokePrefab();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InvokePrefab()
    {
        InvokeRepeating("PrefabInstantiate", 2f, 1.5f);
    }

    void PrefabInstantiate()
    {
        index = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[index], spawnPos, Quaternion.identity);
    }
}
