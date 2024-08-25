using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] TimerBar timerBar;


    public int maxTimer = 30;
    public int currentTimer;
    public int secondsAlive;
    public int minutesAlive;

    public bool fixTimer = true;

    // Start is called before the first frame update
    void Start()
    {
        currentTimer = maxTimer;
        timerBar.SetMaxTimer(maxTimer);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTimer > maxTimer)
        {
            currentTimer = maxTimer;
        }

        if (fixTimer && currentTimer > 0)
        {
            StartCoroutine(ReducingTime());
           // Debug.Log("Tempo vivo: " + minutesAlive + " : " + secondsAlive);
        }
        
        if(secondsAlive == 60)
        {
            secondsAlive = 0;
            minutesAlive++;
        }
    }

    IEnumerator ReducingTime()
    {
        fixTimer = false;

        currentTimer--;
        timerBar.SetCurrentTimer(currentTimer);

        secondsAlive++;

        //Debug.Log(currentTimer);

        yield return new WaitForSeconds(1f);
        fixTimer = true;
    }

}
