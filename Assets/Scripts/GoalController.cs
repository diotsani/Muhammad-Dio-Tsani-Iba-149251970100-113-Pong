using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public ScoreManager manager;

    public GameObject floatGoal1;
    public GameObject floatGoal2;

    void Start()
    {
        
    }

    void Update()
    {
        
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
