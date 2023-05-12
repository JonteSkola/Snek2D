using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
    int direction;
    public float moveTime = 1;
    float lastMove = 0;

    public SnakeTail tail;

    public SnakeTail tailPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.name.Contains("Wall"))
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            SnakeTail newTail = Instantiate(tailPrefab);

            tail.AddTail(newTail);
        }

        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = 0;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = 1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = 2;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = 3;
        }

        if (lastMove + moveTime <= Time.time)
        {
            Vector3 move = Vector3.zero;
            lastMove = Time.time;

            if (direction == 0)
            {
                move = Vector3.right;
            }
            else if (direction == 1)
            {
                move = Vector3.down;
            }
            else if (direction == 2)
            {
                move = Vector3.up;
            }
            else if (direction == 3)
            {
                move = Vector3.left;
            }

            if (tail != null)
            {
                tail.Move(transform.position);
            }
            transform.Translate(move);
        }
    }

    public void RotatePlayer()
    {
        if (direction == 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, -90);
        }
        else if (direction == 1)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if (direction == 2)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction == 3)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
    }
}