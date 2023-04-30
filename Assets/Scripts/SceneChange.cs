using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    //public float delay = 10;
    public string NextScene = "GameScene";

    void Start()
    {
        //StartCoroutine(LoadLevelAfterDelay(delay));
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

    //IEnumerator LoadLevelAfterDelay(float delay)
    //{
    //    yield return new WaitForSeconds(delay);
    //    SceneManager.LoadScene(NextScene);
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
