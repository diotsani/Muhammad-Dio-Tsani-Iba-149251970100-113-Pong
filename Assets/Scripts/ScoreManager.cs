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

    [Header("Ball")]
    public BallController ball;
    public GameObject ballDupe;

    void Start()
    {
        
    }


    void Update()
    {
        if (ballDupe == null)
        {
            ballDupe = GameObject.FindWithTag("BallDupe");
            
        }
    }

    public void AddRightScore(int increment)
    {
        rightScore += increment;
        ball.ResetBallRight();

        if (ballDupe != null)
        {
            ballDupe.GetComponent<BallDuplicate>().DestroyBall();
        }

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

        if (ballDupe != null)
        {
            ballDupe.GetComponent<BallDuplicate>().DestroyBall();
        }

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
