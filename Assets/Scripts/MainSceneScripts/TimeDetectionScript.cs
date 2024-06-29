using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDetectionScript : MonoBehaviour
{
    public static int sec = 0;
    public static int min = 0;
    public static int hour = 0;
    public static int milisec = 0;

    public Text timeText;
    public static string absTime;

    void FixedUpdate()
    {
        Invoke("TimeChange", 1f);
    }

    public void TimeChange()
    {
        milisec++;
        if(milisec == 60)
        {
            milisec = 0;
            sec++;
        }
        if(sec == 60)
        {
            sec = 0;
            min++;
        }
        if (min == 60)
        {
            min = 0;
            hour++;
        }

        if (hour < 10 && min < 10 && sec < 10)
        {
            timeText.text = "0" + hour.ToString() + ":" + "0" + min.ToString() + ":" + "0" + sec.ToString();
        }
        if(hour < 10 && min < 10 && sec >= 10)
        {
            timeText.text = "0" + hour.ToString() + ":" + "0" + min.ToString() + ":" + sec.ToString();
        }
        if(hour < 10 && min >= 10 && sec >= 10)
        {
            timeText.text = "0" + hour.ToString() + ":" + min.ToString() + ":" + sec.ToString();
        }
        if(hour < 10 && min >= 10 && sec < 10)
        {
            timeText.text = "0" + hour.ToString() + ":" + min.ToString() + ":" + "0" + sec.ToString();
        }

        absTime = timeText.text;
    }
}
