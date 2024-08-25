using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralTrigger : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Circle") || other.gameObject.CompareTag("Triangle"))
        {
            gameManager.onCentralArea = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Circle") || other.gameObject.CompareTag("Triangle"))
        {
            gameManager.onCentralArea = false;
        }
    }
}
