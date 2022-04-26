using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public delegate void CorrectAnswerHandler();
    public static event CorrectAnswerHandler OnCorrectAnswer;
    public delegate void InCorrectAnswerHandler();
    public static event InCorrectAnswerHandler OnInCorrectAnswer;

    public delegate void GameEndedHandler();
    public static event GameEndedHandler OnGameEnd;

    Questions questions;
    public TextAsset jsonFile;
    public GameObject QAndAPanel;

    Question currentQuestion;
    int currentQuestionIndex = 0;
    int maxQuestions = 10;
    private bool buttonClicked;

    // Start is called before the first frame update
    void Start()
    {
        GetAllQuestions();
        GetCurrentQuestion();
        DisplayQuestionsAndAnswers(); 
    }

    private void GetCurrentQuestion()
    {
        currentQuestion = questions.questionsArray[currentQuestionIndex];
    }


    private void GetAllQuestions()
    {
        questions = JsonHandler.GenerateQuestions(jsonFile);

    }

    private void DisplayQuestionsAndAnswers()
    {
        foreach (ISlideable UIElement in QAndAPanel.GetComponentsInChildren<ISlideable>())
        {
            UIElement.Slide();
        }
        
        QAndAPanel.GetComponent<DisplayQuestionsAndAnswers>().Display(currentQuestionIndex + 1, currentQuestion.questionString, currentQuestion.answersArray);
        
    }

    public void ButtonClicked(Button button)
    {
        if(buttonClicked == false)
        {
            buttonClicked = true;

            string playerAnswer = button.gameObject.GetComponentInChildren<Text>().text;

            if (playerAnswer == currentQuestion.correctAnswer)
            {
                DoAnimate.Correct(button.transform);
                Correct();
            }
            else
            {
                DoAnimate.Incorrect(button.transform);
                Incorrect();

            }

            StartCoroutine(WaitForSeconds(1));
        }
        
       
        
        
    }

    void Correct()
    {
        if(OnCorrectAnswer!= null)
        {
            OnCorrectAnswer();
        }
    }

    void Incorrect()
    {
        OnInCorrectAnswer();
    }

    IEnumerator WaitForSeconds(int seconds)
    {
        yield return new WaitForSeconds(seconds);
        NextQuestion();
        buttonClicked = false;
    }

    void NextQuestion()
    {
        if(currentQuestionIndex < maxQuestions-1)
        {
            currentQuestionIndex++;
            GetCurrentQuestion();
            DisplayQuestionsAndAnswers();
        }
        else
        {
            EndOfGame();
        }
    }

    private void EndOfGame()
    {
        RestartQuiz();
        if (OnGameEnd != null)
        {
            OnGameEnd();
        }
        
    }

    void RestartQuiz()
    {
        currentQuestionIndex = 0;
        GetCurrentQuestion();
        DisplayQuestionsAndAnswers();
    }
}
