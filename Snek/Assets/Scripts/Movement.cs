using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;

    private Vector3 direction = Vector3.right;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector3.right;
        }

        transform.position += direction * speed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name.Contains("Wall"))
        {
            Destroy(gameObject);
        }
    }
}