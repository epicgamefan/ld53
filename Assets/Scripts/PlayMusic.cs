using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public string music;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.PlayMusic(music);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
