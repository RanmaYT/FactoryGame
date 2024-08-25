using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text pointsText;
    [SerializeField] TMP_Text streakText;
    [SerializeField] TMP_Text maxStreakText;
    [SerializeField] TMP_Text timeAliveText;

    private PointsManager pointManager;
    private TimerManager timerManager;

    // Start is called before the first frame update
    void Start()
    {
        pointManager = FindAnyObjectByType<PointsManager>();
        timerManager = FindAnyObjectByType<TimerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsText.SetText("Points: " + pointManager.points);
        streakText.SetText("Streak: " + pointManager.streak);
        maxStreakText.SetText("Max Streak: " + pointManager.maxStreak);
        timeAliveText.SetText("Time Alive: " + timerManager.minutesAlive + ":" + timerManager.secondsAlive);
    }
}
