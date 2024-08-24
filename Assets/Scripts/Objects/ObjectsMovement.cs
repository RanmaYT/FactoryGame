using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class ObjectsMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private ButtonManager buttonManager;

    public float speed = 1f;
    public float maxDistance;
    public Vector2 direction = Vector2.zero;
    public bool setted;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        buttonManager = FindAnyObjectByType<ButtonManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonManager.hMove != 0 && !setted)
        {
            direction = new Vector2(buttonManager.hMove, 0);
            buttonManager.hMove = 0;
            setted = true;
        }
    }

    private void FixedUpdate()
    {
        Movement();   
    }

    private void Movement()
    {
        // I need to move them in the y pos until it's equals -3;

        if(transform.position.y > maxDistance)
        {
            rb.velocity = Vector2.down * speed;
        }
        else
        {
            // I will need to stop after getting in the -3;

            rb.velocity = direction;
        }



        // Get the direction from the buttons;
    }
}
