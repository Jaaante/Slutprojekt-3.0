using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody2D car;
    void Start()
    {
        car = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        car.velocity = Vector2.zero;

        Vector2 dir = car.velocity;

        if (Input.GetKey(KeyCode.A))
        {
            dir.x = -1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            dir.x = 1;
        }

        if (Input.GetKey(KeyCode.W))
        {
            dir.y = 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            dir.y = -1;
        }

        car.velocity = dir * speed;

        if (car.velocity != Vector2.zero)
        {
            transform.right = car.velocity;
        }
    }
}
