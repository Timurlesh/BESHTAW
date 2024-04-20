using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    [SerializeField] private float heartvalue;

    private void Start()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<Player_Control>().CanDamage == true)
            {
                collision.GetComponent<Health>().TakeDamage(heartvalue);
            }
            

        }
    }
}
