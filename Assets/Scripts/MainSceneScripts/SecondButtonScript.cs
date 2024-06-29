using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SecondButtonScript : MonoBehaviour
{

    public Text cNRText2;

    public void Update()
    {
        if (Input.GetKeyDown("2"))
        {
            SecondButtonClick();
        }
    }

    public void SecondButtonClick()
    {
        if (GameObject.Find("SecondButton").GetComponentInChildren<Text>().text == MainActionScript.countryName)
        {
            MainActionScript.rightGuessedCountries++;
            //print("Correct");
            cNRText2.color = Color.green;
            cNRText2.text = "Correct!";
            Invoke("TextDestroyer", 1f);
        }
        else
        {
            //print("Wrong");
            cNRText2.color = Color.red;
            cNRText2.text = "Wrong!";
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
        cNRText2.text = "";
    }
}
