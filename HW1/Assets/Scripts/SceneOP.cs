using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOP : MonoBehaviour
{
    
    public void Scene1Open()
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Scene2Open()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void Scene3Open()
    {
        SceneManager.LoadScene("Scene3");
    }

    public void Scene4Open()
    {
        SceneManager.LoadScene("Scene4");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
