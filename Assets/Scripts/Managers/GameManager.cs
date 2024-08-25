using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;

    private PointsManager pointsManager;
    private TimerManager timerManager;

    public bool onCentralArea;

    public int streakLevel;
    public int nextStreakLevel;
    public int initialStreakLevel = 5;
    public bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
        pointsManager = FindAnyObjectByType<PointsManager>();
        timerManager = FindAnyObjectByType<TimerManager>();

        gameOverScreen.SetActive(false);

        nextStreakLevel = initialStreakLevel;
    }

    // Update is called once per frame
    void Update()
    {
        if(pointsManager.streak == 0)
        {
            streakLevel = 0;
            nextStreakLevel = initialStreakLevel;
        }
        else if(pointsManager.streak >= nextStreakLevel)
        {
            streakLevel++;
            nextStreakLevel *= 2;
        }

        if(timerManager.currentTimer <= 0)
        {
            gameOver = true;
            gameOverScreen.SetActive(true);
        }
    }
}
