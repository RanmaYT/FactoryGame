using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private PointsManager points;
    [SerializeField] private TimerManager timer;
    [SerializeField] TMP_Text pointsText;
    [SerializeField] TMP_Text maxStreakText;
    [SerializeField] TMP_Text timeAliveText;

    private int index;

    // Update is called once per frame
    void Update()
    {
        SetTexts();
    }

    private void SetTexts()
    {
        pointsText.SetText("Points: " + points.points);
        maxStreakText.SetText("Max streak:" + points.maxStreak);
        timeAliveText.SetText("Time Alive: " + timer.minutesAlive + ":" + timer.secondsAlive);
    }

    public void PlayAgainButton()
    {
        index = 1;
        StartCoroutine(LoadCooldown());
    }

    public void MainMenuButton()
    {
        index = 0;
        StartCoroutine(LoadCooldown());
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    IEnumerator LoadCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(index);
    }
}
