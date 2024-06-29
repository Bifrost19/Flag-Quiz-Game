using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TryAgainButtonScript : MonoBehaviour
{

    public void TryAgainButton()
    {
        MainActionScript.isThereSelection = false;
        MainActionScript.countryName = "";
        MainActionScript.prevCountries.Clear();
        MainActionScript.prevCountriesArray = MainActionScript.prevCountries.ToString().Split(' ');
        MainActionScript.isFirstTime = true;


        SceneManager.LoadScene("MainScene");
    }


}
