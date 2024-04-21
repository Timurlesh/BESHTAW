using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private float heartvalue;
    public GameObject VR;
    public bool Dop;
    private void Start()
    {
    
            transform.position += new Vector3(0, 0.5f, 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Dop == true)
            {
                    collision.gameObject.GetComponent<Health>().startingHealth += 1;
                    collision.gameObject.GetComponent<Health>().addHealth(heartvalue);
                    Instantiate(VR, transform.position, transform.rotation);
                    Destroy(gameObject);
                
            }
            else
            {
                collision.gameObject.GetComponent<Health>().addHealth(heartvalue);
                Instantiate(VR, transform.position, transform.rotation);
                Destroy(gameObject);
            }
            

        }
    }
}
