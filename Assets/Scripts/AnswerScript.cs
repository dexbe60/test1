using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;
    public static AnswerScript Instance;
    public void Answer(char value)
    {
        isCorrect = quizManager.LnP.Letter == value;
        if (isCorrect)
        {
            Debug.Log("Correct Answer");
            quizManager.correct();            
        }
        else
        {
            Debug.Log("Wrong Answer");
        }
    }
    private void Awake()
    {
        Instance = this;
    }
}

