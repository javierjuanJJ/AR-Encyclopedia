using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoToScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
    
    public void QuitApp()
    {
        Application.Quit();
    }
}
