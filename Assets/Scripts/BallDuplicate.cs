using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDuplicate : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;

    private Rigidbody2D rig;

    public GameObject floatSpeedUp;
    public GameObject floatDupeBall;

    private Vector2 plusSpeed = new Vector2(1.5f, 3f);
    private Vector2 minusSpeed = new Vector2(-1.5f, -3f);

    //public GameObject ballDupe;
    [Header("Padlle Collison")]
    public PaddleController[] paddleController;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        RandomBall();
        FloatText();

        Destroy(gameObject, 5f);
        transform.localPosition += new Vector3(0, 0, 0);
    }

    private void Update()
    {
        //transform.Translate(speed * Time.deltaTime);
    }

    public void FloatText()
    {
        GameObject floatText = Instantiate(floatDupeBall, transform.position, Quaternion.identity);
        floatText.SetActive(true);
    }

    public void DestroyBall()
    {
        Destroy(gameObject);
    }

    // RANDOM BALL-------------------------------------------------------------
    public void RandomBall()
    {
        float randomDirection = Random.Range(0, 2);

        if (randomDirection < 1.0f)
        {
            rig.velocity = minusSpeed;
        }
        else
        {
            rig.velocity = plusSpeed;
        }
    }

    // POWER UP------------------------------------------------------------------
    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
        GameObject floatText = Instantiate(floatSpeedUp, transform.position, Quaternion.identity);
        floatText.SetActive(true);
    }

    //----------------------
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Left Paddle")
        {
            paddleController[0].isLeftPaddle = true;
            paddleController[1].isRightPaddle = false;
            Debug.Log("Left Paddle");
        }

        if (collision.gameObject.tag == "Right Paddle")
        {
            paddleController[0].isLeftPaddle = false;
            paddleController[1].isRightPaddle = true;
            Debug.Log("Right Paddle");
        }
    }
}
