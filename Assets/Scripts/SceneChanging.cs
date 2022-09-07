using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanging : MonoBehaviour
{
    public void SceneChange()
    {
            SceneManager.LoadScene(1);
    }
    public void Exit()
    {
            Application.Quit();
    }
    public void Menu()
    {
            SceneManager.LoadScene(0);
    }
}
