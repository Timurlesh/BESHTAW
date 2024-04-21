using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float startingHealth;
    public float currentHealth { get; private set; }
    private int God;
    private void Awake()
    {
        currentHealth = startingHealth;

    }

    public void TakeDamage(float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            God = 3;
            
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }

    public void addHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
        TakeDamage(1);
        }
        if (God > 0)
        {
            StartCoroutine(wait(1));
        }
        else
        {
            gameObject.GetComponent<Player_Control>().CanDamage = true;
        }
    }

    private IEnumerator wait(float _time)
    {
        yield return new WaitForSeconds(_time);
        God -= 1;
        if (God == 0)
        {
            gameObject.GetComponent<Player_Control>().CanDamage = true;
        }
        else
        {
            gameObject.GetComponent<Player_Control>().CanDamage = false;
            gameObject.GetComponent<Player_Control>().animator.Play("damaged");

        }
    }
}
