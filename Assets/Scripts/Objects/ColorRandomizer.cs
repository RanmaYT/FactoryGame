using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    private SpriteRenderer sr;
    private ObjectsValue objectsValue;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        objectsValue = GetComponent<ObjectsValue>();
        sr = GetComponent<SpriteRenderer>();

        ColorChange();
    }

    void ColorChange()
    {
        index = Random.Range(1, 21);

        if (index <= 4)
        {
            if (gameObject.CompareTag("Triangle"))
            {
                sr.color = Color.blue;

                objectsValue.timeBonus++;
                objectsValue.pointBonus++;
            }
            else
            {
                sr.color = Color.red;

                objectsValue.timeBonus++;
                objectsValue.pointBonus++;
            }
        }

        if (index == 10)
        {
            sr.color = Random.ColorHSV();
            objectsValue.timeBonus += 2;
            objectsValue.pointBonus += 3;
        }
    }
}
