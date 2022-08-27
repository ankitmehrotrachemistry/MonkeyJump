using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileControl : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX;
    float moveSpeed = 20f;

    private float jumpForce = 10.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -4.5f, 4.5f), 0);

    }

    void FixedUpdate()
    {
        //var x = Physics.gravity = new Vector3(0, -1f, 0f);
        rb.velocity = new Vector2(dirX, 0);
        rb.AddForce(new Vector2(0.2f,5f));
    }
}
