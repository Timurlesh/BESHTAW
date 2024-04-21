using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X2shet : MonoBehaviour
{
    public GameObject End;

    private void Start()
    {
        End.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            End.SetActive(true);
        }
    }
}
