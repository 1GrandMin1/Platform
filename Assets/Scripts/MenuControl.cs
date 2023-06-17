using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public GameObject panelsettings;
    public void PlayGame()
    {
        Application.LoadLevel("Play");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void settingPanel()
    {
        panelsettings.SetActive(true);
    }
    public void Exit()
    {
        panelsettings.SetActive(false);
    }
    

}
