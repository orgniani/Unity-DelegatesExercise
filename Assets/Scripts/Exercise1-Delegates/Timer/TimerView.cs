using System;
using System.Collections;
using System.Collections.Generic;
using Exercise1_Delegates.Timer;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

//TODO: Complete this class to solve all TODOs and add some nice visual behaviour to the timer.
public class TimerView : MonoBehaviour
{
    [SerializeField] private TMP_Text timerNumber;

    [SerializeField] private SecondsCounter secondsCounter;

    [SerializeField] private AudioSource clockTick;

    //TODO: Subscribe this method to the event found in the SecondsCounter class.
    //TODO: This method should only be subscribed to the event while the component is enabled! 

    private void OnEnable()
    {
        secondsCounter.onSecondPassed += HandleSecondPassed;
    }

    private void OnDisable()
    {
        secondsCounter.onSecondPassed -= HandleSecondPassed;
    }

    private void HandleSecondPassed(int currentSeconds)
    {
        //TODO: Update the timerNumber's text to reflect the current seconds.
        timerNumber.SetText(currentSeconds.ToString());
        clockTick.Play();
    }
}
