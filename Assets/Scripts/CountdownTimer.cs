using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    LevelManager levelManager;
    float CurrentTime = 0f;
    private float StartingTime = 90f;

    public Text CountdownText;

    void Start()
    {
        CurrentTime = StartingTime;
    }

    void Update()
    {
        if(CurrentTime <= 0)
        {
            CurrentTime = 0;
            GameObject.FindObjectOfType<LevelManager>().LoadRequest("Loose");
        }
        else
        {
            CurrentTime -= 1 * Time.deltaTime;
            CountdownText.text = CurrentTime.ToString("0");
        }
    }
}
