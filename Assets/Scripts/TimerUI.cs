using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerUI : MonoBehaviour
{
    public GameObject quizManagerGO;
    Timer timer;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = quizManagerGO.GetComponent<Timer>();
        }

    // Update is called once per frame
    void Update()
    {
        DisplayTimer(timer.ReturnTime());
    }

    void DisplayTimer(float time)
    {
        this.GetComponentInChildren<Text>().text = $"Time:\n" + Mathf.RoundToInt(time);
    }
}
