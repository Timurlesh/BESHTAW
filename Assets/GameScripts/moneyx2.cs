using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyx2 : MonoBehaviour
{
    public static int moneyplus;
    public int moneytime;
    // Start is called before the first frame update
    void Start()
    {
        moneyplus = 1;
        moneytime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (moneytime > 0)
        {
            Wait1();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            moneyplus = 2;
            moneytime += 5;
            Destroy(gameObject);
        }
    }
    private IEnumerator Wait1()
    {
        yield return new WaitForSeconds(1);
        moneytime -= 1;
        if (moneytime == 0)
        {
            moneyplus = 1;
        }
    }
}
