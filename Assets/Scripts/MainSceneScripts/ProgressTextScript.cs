using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressTextScript : MonoBehaviour
{

    public Text mainText;

    void Update()
    {
        mainText.text = MainActionScript.prevCountriesArray.Length + "/314";
    }
}
