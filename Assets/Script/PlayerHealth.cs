using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    int MaxHP = 1;
    public int currentHP = 0;
    Animator animator;

    bool IsInvicible = false;
    bool b = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP <= 0 && !b)
        {
            Die();
            b = !b;
        }
    }
    public void takeDamage()
    {
        if (!IsInvicible)
        {
            Debug.Log("TakeDamage!!");
            currentHP--;
            //animator.SetTrigger("IsHurt");
        }

    }

    public void StartHurt()
    {
        IsInvicible = true;
    }

    public void FinishHurt()
    {
        IsInvicible = false;
    }

    public void Die()
    {
        animator.SetTrigger("IsDead");
    }

    public void IsGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }


}
