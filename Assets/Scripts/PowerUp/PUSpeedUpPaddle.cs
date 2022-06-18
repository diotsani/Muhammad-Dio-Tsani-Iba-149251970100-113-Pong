using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpPaddle : MonoBehaviour
{
    public Collider2D ball;
    public GameObject floatTextSpeedUpPad;

    //public GameObject leftPaddle;
    //public GameObject rightPaddle;

    public PowerUpManager manager;
    public PaddleController[] paddleController;

    void Start()
    {
        StartCoroutine(manager.AutoRemovePowerUp(gameObject));
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if(paddleController[0].isLeftPaddle == true)
            {
                // Long Up the left paddle
                paddleController[0].speed = 8;
                GameObject floatText = Instantiate(floatTextSpeedUpPad, transform.position, Quaternion.identity);
                floatText.SetActive(true);
            }

            if (paddleController[1].isRightPaddle == true)
            {
                // Long Up the right paddle
                paddleController[1].speed = 8;
                GameObject floatText = Instantiate(floatTextSpeedUpPad, transform.position, Quaternion.identity);
                floatText.SetActive(true);
            }
            Debug.Log("Speed Up Paddle Activate");
            manager.RemovePowerUp(gameObject);

        }
    }
}
