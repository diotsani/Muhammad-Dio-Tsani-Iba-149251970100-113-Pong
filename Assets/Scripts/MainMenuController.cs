using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Loading");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created by Muhammad Dio Tsani Iba - 149251970100-113");
    }
}
