using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float time = 0;
    bool timerOn = false;

    public void Start()
    {
        QuizManager.OnGameEnd += StopTimer;
    }

    public void StartTimer()
    {
        timerOn = true;
    }

     void Update()
    {
        if (timerOn)
        {
            time += Time.deltaTime;
        }
    }

    public float ReturnTime()
    {
        return time;
    }

    void StopTimer()
    {
        timerOn = false;
    }

    public void ResetTimer()
    {
        time = 0;
    }
}
