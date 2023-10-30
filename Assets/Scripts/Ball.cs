using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] LivesManager LiveManagerReference;
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody2D>().AddForce(new Vector2(250f, 250f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Zapper") 
        {
            LiveManagerReference.DecreaseLives();
            Destroy(gameObject);
        }
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
