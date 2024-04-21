using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float heartvalue;
    public GameObject VR;
    public Animator animator;

    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(wait(2f));
        gameObject.SetActive(true);
        animator.Play("explode");
        gameObject.SetActive(false);
        transform.position += new Vector3(0, -10, 0);
    }

    private IEnumerator wait(float _time)
    {
        yield return new WaitForSeconds(_time);
        


    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.GetComponent<Player_Control>().CanDamage == true)
            {
                
            collision.GetComponent<Health>().TakeDamage(heartvalue);
            Instantiate(VR, transform.position, transform.rotation);
                
                
            }


        }
    }
}
