using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class play : MonoBehaviour
{
    public void Loadlevel()
    {
        SceneManager.LoadScene(1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
