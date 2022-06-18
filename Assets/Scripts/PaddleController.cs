using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    private Rigidbody2D rig;

    [Header("Key Code")]
    public KeyCode upKey;
    public KeyCode downKey;

    public GameObject obj;
    public bool isLeftPaddle;
    public bool isRightPaddle;

    //Power Up Paddle---------------------------------
    private float timerEffect = 0f;
    private float durationLongUp = 5f;
    private Vector3 normalScale = new Vector3(0.5f, 2f, 1f);
    private Vector3 longUpScale = new Vector3(0.5f, 4f, 1f);

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 movement = GetInput();

        MoveObject(GetInput());


        RemoveEffect();
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }

        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        // Move Object
        //transform.Translate(movement * Time.deltaTime);
        Debug.Log("TEST:" + movement);
        rig.velocity = movement;
    }

    public void ActivateLongUpEffect()
    {
        obj.transform.localScale = longUpScale;
    }

    public void RemoveEffect()
    {
        if(obj.transform.localScale.y >= 4)
        {
            //Invoke("NormalEffect", 5);
            timerEffect += Time.deltaTime;
            if(timerEffect >= durationLongUp)
            { 
                obj.transform.localScale = normalScale;
                Debug.Log("5 Seconds");
                timerEffect -= durationLongUp;
            }
        }
        if(speed == 8)
        {
            timerEffect += Time.deltaTime;
            if (timerEffect >= durationLongUp)
            {
                speed /= 2;
                Debug.Log("5 Seconds");
                timerEffect -= durationLongUp;
            }
        }
    }
    public void NormalEffect()
    {
        obj.transform.localScale = normalScale;
    }
    
}
