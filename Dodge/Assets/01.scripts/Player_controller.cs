using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public Rigidbody player_rigidbody;
    public float speed = 8f;
    int test;
    void Start()
    {
        Debug.Log("æ»≥Á«œººø‰");
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) ==true)
        {
            player_rigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            player_rigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            player_rigidbody.AddForce(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            player_rigidbody.AddForce(speed, 0f, 0f);
        }
        if(this.gameObject.transform.position.y <= -5)
        {
            Die();
        }
    } 
    public void Die()
    {
        gameObject.SetActive(false);
        gameObject.transform.position = Vector3.zero;
        gameObject.SetActive(true);
    }
}
