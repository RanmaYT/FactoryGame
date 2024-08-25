using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsManager : MonoBehaviour
{
    public int points;

    public int streak;
    public int maxStreak;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        streak = 0;
    }

    private void Update()
    {
        if(streak > maxStreak)
        {
            maxStreak = streak;
        }
    }
}
