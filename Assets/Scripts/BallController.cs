using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;

    private Rigidbody2D rig;

    public GameObject floatSpeedUp;

    private Vector2 plusSpeed = new Vector2(3f, 1.5f);
    private Vector2 minusSpeed = new Vector2(-3f, -1.5f);

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        //rig.velocity = speed;
        RandomBall();
    }

    private void Update()
    {
        //transform.Translate(speed * Time.deltaTime);

        
    }

    // RESET BALL---------------------------------------------------------------
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
        RandomBall();
    }

    public void ResetBallRight()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
        rig.velocity = minusSpeed;
    }

    public void ResetBallLeft()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
        rig.velocity = plusSpeed;
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

    
}
