using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class ObjectsMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private ButtonManager buttonManager;
    private GameManager gameManager;

    public float speed = 1f;
    public float maxDistance;
    public Vector2 direction = Vector2.zero;
    public bool setted;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        buttonManager = FindAnyObjectByType<ButtonManager>();
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonManager.hMove != 0 && !setted)
        {
            direction = new Vector2(buttonManager.hMove * 3, 0);
            buttonManager.hMove = 0;
            setted = true;
        }
    }

    private void FixedUpdate()
    {   
        if(!gameManager.onCentralArea)
        {
            Movement();   
        }
        else
        {
            if(!setted)
            {
                rb.velocity = Vector2.zero;
            }
            else
            {
                Movement();
            }
        }
    }

    private void Movement()
    {
        // I need to move them in the y pos until it's equals the max distance;

        if(transform.position.y >= maxDistance)
        {
            rb.velocity = Vector2.down * speed;
        }
        else
        {
            // I will need to stop after getting in the max distance;

            rb.velocity = direction * speed;
        }
    }
}
