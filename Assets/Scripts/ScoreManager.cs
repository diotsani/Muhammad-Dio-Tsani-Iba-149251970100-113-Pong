using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int leftScore;
    public int rightScore;
    
    public int maxScore;

    public GameObject panelGameOver_1;
    public GameObject panelGameOver_2;

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
        ball.ResetBallRight();

        if (rightScore >= maxScore)
        {
            GameOverRedTim();
            StartCoroutine(DelayGameOver());
        }
    }

    public void AddLeftScore(int increment)
    {
        leftScore += increment;
        ball.ResetBallLeft();

        if (leftScore >= maxScore)
        {
            GameOverBlueTim();
            StartCoroutine(DelayGameOver());
        }
    }

    public void GameOverBlueTim()
    {
        panelGameOver_1.SetActive(true);
        
    }

    public void GameOverRedTim()
    {
        panelGameOver_2.SetActive(true);

    }

    IEnumerator DelayGameOver()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("MainMenu");
    }
}
