using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public int min;
    
    [SerializeField] private int max;
    
    private int guess;

    private void Start()
    {
        Debug.Log($"Загадай число от {min} до {max}");
        CalculateGuess();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            CalculateGuess();
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            CalculateGuess();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Ура! Победа!");
        }
    }

    private void CalculateGuess()
    {
        guess = (min + max) / 2;
        Debug.Log($"Твое число {guess}?");
    }
}
