using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<ButtonScript> ButtonList;
    public LettersAndPool LnP;
    public GameObject[] options;
    public int Difficulty;
    public Text QuestionTxt;
    public GameObject QuizUi;
    public GameObject RestartButton;
 

    private void Start()
    {
        Difficulty = 1;
        generateLetter();
    }

    public void correct()
    {
        Difficulty ++;
        if (Difficulty > 3)
        {
            QuizUi.SetActive(false);
            RestartButton.SetActive(true);
        }
        else
        {
        generateLetter();
        }  
    }

    void SetAnswer()
    {
        LnP.RndLetter(Difficulty*3, Random.value >= 0.5);
        for (int i = 0; i < Difficulty*3; i++)
        {
            ButtonList[i].gameObject.SetActive(true);
            ButtonList[i].SetValue(LnP.LettersAndNumbersPool[i]);
         }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }

    void generateLetter()
    {
        SetAnswer();
        
        QuestionTxt.text = "Find " + LnP.Letter;
    }

}
