using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmaera : MonoBehaviour
{
    public Transform Player;

    private void LateUpdate()
    {
    gameObject.transform.position = new Vector3(Player.position.x, Player.position.y, gameObject.transform.position.z);
        
    }
}
