using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToFinalMusic : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.PlayMusic("Final");
            Destroy(gameObject);
        }
    }
}



