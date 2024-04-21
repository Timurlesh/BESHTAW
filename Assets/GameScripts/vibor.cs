using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vibor : MonoBehaviour
{
    public float pers_number;
    public GameObject silach;
    public GameObject umni;
    public GameObject woman;

    public void right()
    {
        if (pers_number < 3)
        {
            pers_number += 1;
        }
        else
        {
            pers_number = 1;
        }
    }
    public void left()
    {
        if (pers_number > 1)
        {
            pers_number -= 1;
        }
        else
        {
            pers_number = 3;
        }
    }
    public void Loadlevel()
    {
        if (pers_number == 1)
        {
            SceneManager.LoadScene("lvl1");
        }
        else if (pers_number == 2)
        {
            SceneManager.LoadScene("lvl2");
        }
        else
        {

        }
        
    }

    void Update()
    {
        if (pers_number == 1)
        {
            silach.SetActive(true);
            umni.SetActive(false);
            woman.SetActive(false);
        }
        else if (pers_number == 2)
        {
            silach.SetActive(false);
            umni.SetActive(true);
            woman.SetActive(false);
        }
        else if (pers_number == 3)
        {
            silach.SetActive(false);
            umni.SetActive(false);
            woman.SetActive(true);
        }
    }
}
