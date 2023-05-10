using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectFinish : MonoBehaviour
{
    public string NextScene = "WinScene";

    // Start is called before the first frame update
    void Start()
    {
        GameTimer.Instance.StartTimer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameTimer.Instance.StopTimer();
            SceneManager.LoadScene(NextScene);
        }
    }
}
