using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTrigger : MonoBehaviour
{

    private TimerBar timerBar;
    private TimerManager timerManager;
    private PointsManager pointsManager;

    public string objectTag;
    public int timeBonus = 3;
    public int pointBonus = 1;

    private void Start()
    {
        timerManager = FindAnyObjectByType<TimerManager>();
        pointsManager = FindAnyObjectByType<PointsManager>();
        timerBar = FindAnyObjectByType<TimerBar>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(objectTag))
        {
            timerManager.currentTimer += timeBonus;
            pointsManager.points += pointBonus;
            pointsManager.streak++;

            timerBar.SetCurrentTimer(timerManager.currentTimer);

            Destroy(other.gameObject);
        }
        else
        {
            pointsManager.streak = 0;

            timerManager.currentTimer -= timeBonus;
            timerBar.SetCurrentTimer(timerManager.currentTimer);


            Destroy(other.gameObject);
        }
    }
}
