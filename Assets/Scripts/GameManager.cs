using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject panelBackMainMenu;
    public bool gameIsPaused;

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {

    }

    public void ButtonBackMainMenu()
    {
        gameIsPaused = !gameIsPaused;
        PanelBack();

    }

    public void PanelBack()
    {
        if (gameIsPaused)
        {
            panelBackMainMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            panelBackMainMenu.SetActive(false);
            Time.timeScale = 1;
        }

    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("Credit");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Muhammad Dio Tsani Iba - 149251970100-113");
    }

    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
