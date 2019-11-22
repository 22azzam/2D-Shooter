using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    public GameObject Sword;
    public GameObject Player;
    public GameObject Vision;
    public float SwordSpeed;
    public float shootingSpeed;
    bool PlayerinVision = false;
    // Start is called before the first frame update
    void Start()
    {
        shootingSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        shootingSpeed -= Time.deltaTime;
        if (PlayerinVision == true && shootingSpeed <= 0)
        {
            GameObject SwordCopy = Instantiate(Sword, transform.position, Quaternion.identity) as GameObject;
            if (Player.transform.position.x > transform.position.x)
                SwordCopy.GetComponent<Rigidbody2D>().velocity = new Vector2(SwordSpeed, 0);
            else SwordCopy.GetComponent<Rigidbody2D>().velocity = new Vector2(-SwordSpeed, 0);
            shootingSpeed = 1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.tag == "Player")
        {
            PlayerinVision = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerinVision = false;
        }
    }
    }
