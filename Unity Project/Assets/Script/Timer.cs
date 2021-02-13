using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] float time_a;
    public Text timerText;
    public GameObject restartButton;
    public GameObject timeupText;
    public GameObject timerrText;
    public GameObject shootImage;
    public bool gameStarted = true;

    float timeMax;
    
    void Update()
    {
        Timee();
    }
    public void Timee()
    {
        timerText.text = "TIME: " + timeMax;
        time_a -= Time.deltaTime;
        timeMax = Mathf.Floor(time_a);
        if (time_a <= 0)
        {
            time_a = 0;
            gameStarted = false;
            shootImage.SetActive(false);
            timerrText.SetActive(false);
            timeupText.SetActive(true);
            restartButton.SetActive(true);                       
        }
    }
}
