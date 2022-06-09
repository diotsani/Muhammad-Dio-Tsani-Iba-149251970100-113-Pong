using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    
    public int maxScore;

    public GameObject panelGameOver;

    public BallController ball;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBall();

        if(rightScore >= maxScore)
        {
            GameOver();
            StartCoroutine(DelayGameOver());
        }
    }

    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBall();

        if (leftScore >= maxScore)
        {
            GameOver();
            StartCoroutine(DelayGameOver());
        }
    }

    public void GameOver()
    {
        panelGameOver.SetActive(true);
        
    }

    IEnumerator DelayGameOver()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("MainMenu");
    }
}
