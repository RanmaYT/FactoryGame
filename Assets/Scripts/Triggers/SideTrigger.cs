using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTrigger : MonoBehaviour
{
    [SerializeField] AudioSource perfectSound;
    [SerializeField] AudioSource missSound;

    private TimerBar timerBar;
    private TimerManager timerManager;
    private PointsManager pointsManager;

    public string objectTag;

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
            perfectSound.Play();

            timerManager.currentTimer += other.gameObject.GetComponent<ObjectsValue>().timeBonus;
            pointsManager.points += other.gameObject.GetComponent<ObjectsValue>().pointBonus; ;
            pointsManager.streak++;

            timerBar.SetCurrentTimer(timerManager.currentTimer);

            Destroy(other.gameObject);
        }
        else
        {
            missSound.Play();

            pointsManager.streak = 0;

            timerManager.currentTimer -= other.gameObject.GetComponent<ObjectsValue>().timeBonus;
            timerBar.SetCurrentTimer(timerManager.currentTimer);


            Destroy(other.gameObject);
        }
    }
}
