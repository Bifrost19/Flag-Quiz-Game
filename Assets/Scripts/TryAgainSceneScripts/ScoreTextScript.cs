using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;
    void Update()
    {
        scoreText.text = Mathf.Round((MainActionScript.rightGuessedCountries * 100)/ 314).ToString() + " %";
        timeText.text = TimeDetectionScript.absTime; 
    }
}
