using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    [Header("Collison Ball")]
    public Collider2D ball;
    public GameObject ballDupe;

    public bool isRight;
    public ScoreManager manager;

    public GameObject floatGoal1;
    public GameObject floatGoal2;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            if(isRight)
            {
                manager.AddRightScore(1);
                FloatGoal1();
                
            }
            else
            {
                manager.AddLeftScore(1);
                FloatGoal2();
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BallDupe")
        {
            Debug.Log("BallDupe");
            if (isRight)
            {
                manager.AddRightScore(1);
                FloatGoal1();

            }
            else
            {
                manager.AddLeftScore(1);
                FloatGoal2();
            }
        }
    }

    public void FloatGoal1()
    {
        GameObject floatText = Instantiate(floatGoal1, transform.position, Quaternion.identity);
        floatText.SetActive(true);
        Destroy(floatText, 1f);
    }

    public void FloatGoal2()
    {
        GameObject floatText = Instantiate(floatGoal2, transform.position, Quaternion.identity);
        floatText.SetActive(true);
        Destroy(floatText, 1f);
    }
}
