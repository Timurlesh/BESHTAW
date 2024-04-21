using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F : MonoBehaviour
{
    public static int moneytime;

    void Update()
    {
        if (F.moneytime > 0)
        {
            Wait1();
        }
    }
    private IEnumerator Wait1()
    {
        yield return new WaitForSeconds(1);
        F.moneytime -= 1;
    }
}
