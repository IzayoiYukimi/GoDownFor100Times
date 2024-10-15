using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    GameObject m_Player;

    bool isAttack = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAttack)
        {
            TrapAttack();
        }
    }



    public void SetIsAttack()
    {
        isAttack = !isAttack;
    }

    void TrapAttack()
    {
        if (m_Player != null)
        {
            m_Player.GetComponent<PlayerHealth>().takeDamage();
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_Player = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_Player = null;
        }
    }
}
