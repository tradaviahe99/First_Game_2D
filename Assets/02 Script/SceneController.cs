using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour

{

    public static SceneController instance;
    private void Awake() {
        if (instance == null) {
            instance = this;
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void LoadScene (string  sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}

