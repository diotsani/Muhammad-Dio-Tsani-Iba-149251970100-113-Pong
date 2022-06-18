using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULongUpPaddle : MonoBehaviour
{
    public Collider2D ball;
    public GameObject floatTextLongUp;
    //public GameObject leftPaddle;
    //public GameObject rightPaddle;

    public PowerUpManager manager;
    public PaddleController[] paddleController;

    private Vector3 upScale = new Vector3(0.5f, 4f, 1f);

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
                //paddleController[0].gameObject.transform.localScale = upScale;
                paddleController[0].ActivateLongUpEffect();

                GameObject floatText = Instantiate(floatTextLongUp, transform.position, Quaternion.identity);
                floatText.SetActive(true);
            }

            if (paddleController[1].isRightPaddle == true)
            {
                // Long Up the right paddle
                //paddleController[1].gameObject.transform.localScale = upScale;
                paddleController[1].ActivateLongUpEffect();

                GameObject floatText = Instantiate(floatTextLongUp, transform.position, Quaternion.identity);
                floatText.SetActive(true);
            }
            Debug.Log("Long Up Paddle Activate");
            manager.RemovePowerUp(gameObject);

        }
    }
}
