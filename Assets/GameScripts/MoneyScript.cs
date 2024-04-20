using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject VR;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            MoneySchet.coin += moneyx2.moneyplus;
            Instantiate(VR, transform.position, transform.rotation);
;            Destroy(gameObject);
        }
    }
}