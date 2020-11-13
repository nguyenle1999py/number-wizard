using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI textGuess;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        max++;
        NextGuess();
        Debug.Log(max.ToString());
        Debug.Log(min.ToString());
    }

    public void PressHigher()
    {
        min = guess;
        NextGuess();

    }

    public void PressLower()
    {
        max = guess;
        NextGuess();

    }

    private void NextGuess()
    {
        guess = Random.Range(min, max);
        textGuess.text = guess.ToString();
        Debug.Log(guess.ToString());
    }

    
}
