using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    public bool CanDamage;
    public float horizontal;
    private bool flipRight = true;
    public Animator animator;
    public int jumpForce = 10;
    public bool onGround;
    public LayerMask Ground;
    public Transform GroundCheck;
    private float GroundCheckRadius;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        GroundCheckRadius = GroundCheck.GetComponent<CircleCollider2D>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        jump();
        CheckingGround();
        void jump()
        {
            if (onGround && Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play("jump");
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            }
        }

        horizontal = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(horizontal, rb.velocity.y);//(x,y)
        animator.SetFloat("moveX", Mathf.Abs(horizontal));
        if (horizontal > 0 && !flipRight)
        {
            Flip();
        }
        else if (horizontal < 0 && flipRight)
        {
            Flip();
        }
    }
    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, Ground);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
    void Flip()
    {
        flipRight = !flipRight;
        transform.Rotate(0, 180, 0);
        /*       Vector3 theScale = transform.localScale;
               theScale.x = theScale.x * (-1);
               transform.localScale = theScale;*/
    }
}
