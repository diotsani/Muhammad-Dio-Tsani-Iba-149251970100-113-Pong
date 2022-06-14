using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour
{
    public Image loadingBarFill;

    void Start()
    {
        loadingBarFill.fillAmount = 0;
        StartCoroutine(LoadingScenes());
    }

    void Update()
    {
        
    }

    IEnumerator LoadingScenes()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("Game");
        operation.allowSceneActivation = false;

        float progressBarValue = 0;

        while (!operation.isDone)
        {
            progressBarValue = Mathf.MoveTowards(progressBarValue, operation.progress, Time.deltaTime);
            loadingBarFill.fillAmount = progressBarValue;
            if(progressBarValue >= 0.9f)
            {
                loadingBarFill.fillAmount = 1;
                operation.allowSceneActivation = true;
            }
            yield return null;

        }
    }
}
