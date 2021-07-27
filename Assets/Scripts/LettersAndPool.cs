using UnityEngine;
using System.Linq;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

[System.Serializable]
public class LettersAndPool
{
    char[] LettersPool = new char[26];
    char[] NumbersPool = new char[10];
    public char Letter;
    public char[] LettersAndNumbersPool;
    public int CorrectAnswer;

    public LettersAndPool()
    {
        for (int i = 'a', j = 0; i <= 'z'; i++, j++)
        {
            LettersPool[j] = (char)i;
        }
        for (int i = 0, j = 0; i <= 9; i++, j++)
        {
            NumbersPool[j] = i.ToString()[0];
        }
    }

    public void RndLetter(int lenght,  bool isnumber)
    {
        List<char> array;
        if (isnumber)
        {
            array = NumbersPool.ToList();
        }
        else
        {
            array = LettersPool.ToList();
        }
        array = array.OrderBy(x => Guid.NewGuid()).Take(lenght).ToList();
        CorrectAnswer = Random.Range(0, array.Count);
        Letter = array[CorrectAnswer];
        LettersAndNumbersPool = array.ToArray();
    }
}
