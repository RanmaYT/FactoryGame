using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] GameObject[] prefabs;

    int index;
    GameManager gameManager;
    Vector2 spawnPos;

    public float spawnRate = 1f;
    public bool canSpawn = true;
    public bool canGetHarder = true;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();

        spawnPos = new Vector2(0, 6); 
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn && !gameManager.onCentralArea)
        {
            StartCoroutine(Spawning());
        }

        if (canGetHarder)
        {
            StartCoroutine(IncreaseDifficulty());

            if(spawnRate <= 0.8f)
            {
                spawnRate = 0.8f;
            }
        }
    }

    void PrefabInstantiate()
    {
        index = Random.Range(0, prefabs.Length);
        Instantiate(prefabs[index], spawnPos, Quaternion.identity);
    }

    IEnumerator Spawning()
    {
        canSpawn = false;
        Invoke("PrefabInstantiate", 1f);
        yield return new WaitForSeconds(spawnRate);
        canSpawn = true;
    }

    IEnumerator IncreaseDifficulty()
    {
        canGetHarder = false;
        yield return new WaitForSeconds(30f);
        spawnRate *= 0.8f;
        canGetHarder = true;
    }

    
}
