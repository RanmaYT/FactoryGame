using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] AudioSource clickAudio;

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
            clickAudio.Play();
            hMove = -1;
        }
    }

    public void RightButton()
    {
        if (gameManager.onCentralArea)
        {
            clickAudio.Play();
            hMove = 1;
        }
    }
}
