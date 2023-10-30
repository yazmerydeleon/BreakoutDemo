using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Vector2 startPos = new Vector2(0f, -4.5f); 

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x >= -5.5)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-10f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x <= 5.5)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f);
        }
        else
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }

    }
}
