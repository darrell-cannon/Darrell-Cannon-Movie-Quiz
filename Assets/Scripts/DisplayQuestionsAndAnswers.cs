using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayQuestionsAndAnswers : MonoBehaviour
{
    public GameObject[] answers;
    public GameObject question;
    
    
    public void Display(int questionIndex, string QString, string[] answersArray)
    {
        question.GetComponentInChildren<Text>().text = $"Questions {questionIndex.ToString()}: \n {QString}";

        for (int i = 0; i < answers.Length; i++)
        {
            answers[i].GetComponentInChildren<Text>().text = answersArray[i];
        }
    }
}
