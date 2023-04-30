using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update

    public string NextScene = "GameScene";

    void Start()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene(NextScene);
    }

    public void ExitGame()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
