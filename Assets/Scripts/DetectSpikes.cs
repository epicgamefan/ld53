using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSpikes : MonoBehaviour
{
    private Collision coll;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collision>();
    }

    // Update is called once per frame
    void Update()
    {
        if(coll.onSpikes)
        {
            GameObject startingPoint = GameObject.Find("StartingPoint");
            transform.position = startingPoint.transform.position;
        }
    }
}
