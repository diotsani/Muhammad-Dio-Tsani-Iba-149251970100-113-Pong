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

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 movement = GetInput();

        MoveObject(GetInput());
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
}
