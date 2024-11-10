using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isGrounded = false;
    [SerializeField] public float moveSpeed = 1f;
    [SerializeField] public float forceJump = 300f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            rb.AddForce(new Vector2(0, forceJump));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}
