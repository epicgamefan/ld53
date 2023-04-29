using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFallOffScreen : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPostion = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPostion.y < 0)
        {
            GameObject startingPoint = GameObject.Find("StartingPoint");
            transform.position = startingPoint.transform.position;
            
        }

    }
}
