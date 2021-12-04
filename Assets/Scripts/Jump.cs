using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [HideInInspector]public Rigidbody2D rb;
    public float jumpForce;
    [HideInInspector] public bool onGround;
    public Transform groundCheck;
    public LayerMask ground;
    [HideInInspector] public bool jump;
    [HideInInspector] public Animator am;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        am = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        onGround = Physics2D.Linecast(transform.position, groundCheck.position, ground);
        am.SetBool("OnGround", onGround);
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        rb.gravityScale = rb.velocity.y < 0 ? 5f : 3f;
        if(jump)
        {
            am.SetTrigger("Jump");
            jump = false;
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(Vector2.up * jumpForce);
        }

    }
}
