using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCounter : MonoBehaviour
{
    private bool isGrounded = false;
    [SerializeField] private CapsuleScore cs;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !isGrounded)
        {
            isGrounded = true;
            cs.counterInc();
        }
    }
}
