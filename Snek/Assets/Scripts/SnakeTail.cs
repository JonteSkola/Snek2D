using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    public GameObject front;
    public SnakeTail tail;

    public void Move(Vector3 position)
    {
        if (tail != null)
        {
            tail.Move(transform.position);
        
        }
        transform.position = position;
    }

    public void AddTail(SnakeTail tail)
    {
        if (this.tail != null)
        {
            tail.AddTail(tail);
        }
        else
        {
            this.tail = tail;
            this.tail.front = gameObject;
            this.tail.transform.position = transform.position;
        }
    }
}
