using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator m_animator;
    Rigidbody2D m_rigidbody2D;
    SpriteRenderer m_spriteRenderer;

    float PlayerSpeed = 2.0f;
    float PlayerJumpForce = 5.0f;
    bool IsJumped = false;

    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        m_rigidbody2D = GetComponent<Rigidbody2D>();
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerJump();
    }

    void PlayerMove()
    {
        float MoveDir = Input.GetAxis("Horizontal");

        if (MoveDir != 0)
        {
            m_animator.SetBool("IsMove", true);
            if (MoveDir < 0)
            {
                m_spriteRenderer.flipX = true;
            }
            else if (MoveDir > 0)
            {
                m_spriteRenderer.flipX = false;
            }
        }
        else
        {
            m_animator.SetBool("IsMove", false);
        }
        Vector2 PlayerVel = new Vector2(MoveDir * PlayerSpeed, m_rigidbody2D.velocity.y);
        m_rigidbody2D.velocity = PlayerVel;
    }

    void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsJumped)
            {
                m_rigidbody2D.AddForce(Vector2.up* PlayerJumpForce, ForceMode2D.Impulse);
                m_animator.SetTrigger("IsJump");
                IsJumped = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            IsJumped = false;
        }
    }
}
