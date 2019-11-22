using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jump;
    bool touchingfloor = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed*Time.deltaTime, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.Space)&&touchingfloor==true)
        {
            touchingfloor = false;
             GetComponent<Rigidbody2D>().velocity = new Vector2(0, jump);
        }
    }
    void OnTriggerEnter2D()
    {
        touchingfloor = true;
    }
}

