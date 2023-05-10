using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timer;

    private float elapsedTime = 0;
    private bool running = false;
    public static GameTimer Instance;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)//Prevents duplication when entering a new scene.
        {
            if (Instance.gameObject != this.gameObject)
            {
                Destroy(this.gameObject);
                return;
            }
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);//Keep between scenes.
    }

    // Update is called once per frame
    void Update()
    {
        if(running)
        {
            elapsedTime += Time.deltaTime;
        }

        timer.text = FormatSeconds(elapsedTime);
    }

    string FormatSeconds(float elapsed)
    {
        int d = (int)(elapsed * 100.0f);
        int hours = d / (60*60 * 100);
        int minutes = d / (60 * 100);
        int seconds = (d % (60 * 100)) / 100;
        int hundredths = d % 100;
        return String.Format("{0:00}:{1:00}:{2:00}.{3:00}", hours,minutes, seconds, hundredths);
    }

    public void ResetTimer()
    {
        elapsedTime = 0;
    }

    public void StartTimer()
    {
        running = true;
    }

    public void StopTimer()
    {
        running = false;
    }
}
