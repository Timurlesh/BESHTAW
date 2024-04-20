using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth { get; private set; }
    private void Awake()
    {
        currentHealth = startingHealth;

    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            gameObject.GetComponent<Player_Control>().animator.Play("damaged");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void addHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "DopHeart")
        {
            startingHealth += 1;
            if (currentHealth < startingHealth)
            {
                currentHealth += 1;
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
        TakeDamage(1);
        }
    }
}
