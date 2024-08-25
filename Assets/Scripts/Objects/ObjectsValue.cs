using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsValue : MonoBehaviour
{
    public int timeBonus;
    public int pointBonus;

    // Start is called before the first frame update
    void Start()
    {
        timeBonus = Random.Range(1, 3);
        pointBonus = Random.Range(1, 3);
    }
}
