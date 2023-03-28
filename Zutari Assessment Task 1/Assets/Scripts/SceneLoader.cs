using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{

    //Loads scene with scene name in inspector
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
