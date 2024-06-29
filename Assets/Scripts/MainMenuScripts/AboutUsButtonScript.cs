using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUsButtonScript : MonoBehaviour
{

    public void AboutUsClick()
    {
        SceneManager.LoadScene("AboutUsScene");
    }
}
