using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator am;
    public float minSpeed;
    public float maxSpeed;
    float currentSpeed;
    public float a;
    
    public float horizontalX;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
        currentSpeed = minSpeed;


    }

    // Update is called once per frame
    void Update()
    {
        horizontalX = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontalX) > .1f)
        {
            currentSpeed += a;
            if (currentSpeed > maxSpeed) currentSpeed = maxSpeed;
        }
        else
        {
            currentSpeed = minSpeed;
        }
        if (Mathf.Abs(rb.velocity.x) < .1f)
        {
            currentSpeed = minSpeed;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalX * currentSpeed, rb.velocity.y);
        am.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
    }
}
