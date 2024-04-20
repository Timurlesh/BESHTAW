using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private float heartvalue;

    private void Start()
    {
    
            transform.position += new Vector3(0, 0.5f, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().addHealth(heartvalue);
            Destroy(gameObject);

        }
    }
}
