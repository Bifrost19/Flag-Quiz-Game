using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FourthButtonScript : MonoBehaviour
{

    public Text cNRText4;

    public void Update()
    {
        if (Input.GetKeyDown("4"))
        {
            FourthButtonClick();
        }
    }

    public void FourthButtonClick()
    {
        if (GameObject.Find("FourthButton").GetComponentInChildren<Text>().text == MainActionScript.countryName)
        {
            MainActionScript.rightGuessedCountries++;
            //print("Correct");
            cNRText4.color = Color.green;
            cNRText4.text = "Correct!";
            Invoke("TextDestroyer", 1f);
        }
        else
        {
            //print("Wrong");
            cNRText4.color = Color.red;
            cNRText4.text = "Wrong!";
            Invoke("TextDestroyer", 1f);
        }

        if (MainActionScript.prevCountriesArray.Length != 314)
        {
            GameObject.Find(MainActionScript.countryName).transform.position = MainActionScript.prevFlagPos;
            MainActionScript.prevFlagPos = new Vector3(0, 0, 0);
            MainActionScript.isThereSelection = false;
        }

        if (MainActionScript.prevCountriesArray.Length == 314)
        {

            SceneManager.LoadScene("TryAgainScene");
        }

    }

    public void TextDestroyer()
    {
        cNRText4.text = "";
    }
}
