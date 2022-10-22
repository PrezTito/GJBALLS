using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    [SerializeField]private GameObject SettingsUI;
    [SerializeField]private GameObject PlayUI;
    [SerializeField]private GameObject MainMenuEventsystem;

    public void Start()
    {
        PlayUI.SetActive(false);
        SettingsUI.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("AlexPlayground");
    }
    public void Settings()
    {
        SettingsUI.SetActive(true);
        PlayUI.SetActive(false);
        MainMenuEventsystem.SetActive(false);
    }

    public void PlayButton()
    {
        MainMenuEventsystem.SetActive(false);
        PlayUI.SetActive(true);
        SettingsUI.SetActive(false);
    }

    public void ReturnMenu()
    {
        MainMenuEventsystem.SetActive(true);
        PlayUI.SetActive(false);
        SettingsUI.SetActive(false);
    }
}
