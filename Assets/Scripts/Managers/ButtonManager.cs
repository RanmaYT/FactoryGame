using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    private GameManager gameManager;

    public float hMove;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    public void LeftButton()
    {
        if (gameManager.onCentralArea)
        {
            hMove = -1;
        }
    }

    public void RightButton()
    {
        if (gameManager.onCentralArea)
        {
            hMove = 1;
        }
    }
}
