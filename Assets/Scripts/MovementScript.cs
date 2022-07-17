using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float rotateSpeed = 1.0f;

    public bool upPressed = false;
    public bool downPressed = false;
    public bool leftPressed = false;
    public bool rightPressed = false;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameManager.gameOver)
        {
            if (upPressed)
            {
                MoveUp();
            }

            if (downPressed)
            {
                MoveDown();
            }

            if (rightPressed)
            {
                MoveRight();
            }

            if (leftPressed)
            {
                MoveLeft();
            }
        } 

    }

    public void MoveUp()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }

    public void MoveDown()
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * moveSpeed);
    }

    public void MoveLeft()
    {
        transform.Rotate(0, -rotateSpeed, 0);
    }

    public void MoveRight()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }

    public void ToggleUp(bool val)
    {
        upPressed = val;
    }

    public void ToggleDown(bool val)
    {
        downPressed = val;
    }

    public void ToggleLeft(bool val)
    {
        leftPressed = val;
    }

    public void ToggleRight(bool val)
    {
        rightPressed = val;
    }
}
