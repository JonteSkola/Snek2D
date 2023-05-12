using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerCollision : MonoBehaviour
{
    public int foodOnMap = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name.Contains("Tail"))
        {
            foodOnMap = 0;
            Destroy(gameObject);
        }
    }
}
