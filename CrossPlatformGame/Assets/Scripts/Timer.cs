using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timeLeft = 120f;
    public Text text;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = Mathf.Round(timeLeft) + "s remaining!";

        if (timeLeft < 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
