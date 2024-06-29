using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstButtonScript : MonoBehaviour
{

    public Text cNRText1;

    public void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            FirstButtonClick();
        }
    }

    public void FirstButtonClick()
    {
        if(GameObject.Find("FirstButton").GetComponentInChildren<Text>().text == MainActionScript.countryName)
        {
            MainActionScript.rightGuessedCountries++;
            //print("Correct");
            cNRText1.color = Color.green;
            cNRText1.text = "Correct!";
            Invoke("TextDestroyer", 1f);
        }
        else
        {
            //print("Wrong");
            cNRText1.color = Color.red;
            cNRText1.text = "Wrong!";
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
        cNRText1.text = "";
    }
}
