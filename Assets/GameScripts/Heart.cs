using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private float heartvalue;
    public GameObject VR;
    private void Start()
    {
    
            transform.position += new Vector3(0, 0.5f, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().addHealth(heartvalue);
            Instantiate(VR, transform.position, transform.rotation);
            Destroy(gameObject);

        }
    }
}
