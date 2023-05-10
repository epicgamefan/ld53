using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    public TMPro.TextMeshProUGUI deathCount;

    private int deaths = 0;
    public static DeathCounter Instance;
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
        deathCount.text = deaths.ToString();
    }

    public void Reset()
    {
        deaths = 0;
    }

    public void Increment()
    {
        deaths++;
    }
}
