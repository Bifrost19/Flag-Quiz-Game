using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThirdButtonScript : MonoBehaviour
{

    public Text cNRText3;

    public void Update()
    {
        if (Input.GetKeyDown("3"))
        {
            ThirdButtonClick();
        }
    }

    public void ThirdButtonClick()
    {
        if (GameObject.Find("ThirdButton").GetComponentInChildren<Text>().text == MainActionScript.countryName)
        {
            MainActionScript.rightGuessedCountries++;
            //print("Correct");
            cNRText3.color = Color.green;
            cNRText3.text = "Correct!";
            Invoke("TextDestroyer", 1f);
        }
        else
        {
            //print("Wrong");
            cNRText3.color = Color.red;
            cNRText3.text = "Wrong!";
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
        cNRText3.text = "";
    }
}
