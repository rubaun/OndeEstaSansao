using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public float timeInitial;
    private bool timeIsRunning = false;
    public Text timeText;
    //private string timeText;
    
    private void Awake() {
        timeInitial = timeRemaining;
    }
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeIsRunning)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                //Debug.Log("tempo acabou");
                timeRemaining = 0;
                timeIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1; //último segundo a ser exibido
        //float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        //float miliseconds = (timeToDisplay % 1) * 1000;
        //timeText.Text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.text = string.Format("{0:00}", seconds);
    }

    public void StopTime()
    {
        timeIsRunning = false;
    }

    public void RestartTime()
    {
        timeRemaining = timeInitial;
    }

    public void StartTime()
    {
        timeIsRunning = true;
    }

}
