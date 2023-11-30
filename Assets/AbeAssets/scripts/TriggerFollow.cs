using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFollow : MonoBehaviour
{
    //This script makes tge object move towards the target, if it enters the trigger collider.
    //It stops moving when the target exist the collider.

    //object to target
    public Transform target;

    //How fast it moves
    public float speed = 1.5f;

    private Rigidbody2D rb;
    private bool following = false;

    // Start is called before the first frame update
    void Start()
    {
        //Grab the rb
        rb = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate is called every time the physics system is updated
    void FixedUpdate()
    {
        if (rb)
        {
            //if baddie sees target
            if (following)
            {
                //Move towards the target
                rb.MovePosition(Vector2.Lerp(transform.position, target.position, Time.fixedDeltaTime * speed));
                Debug.Log("I am following you!");
            }
        }   
    }


    //When the target enters the collision 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            //set the following condition to true
            following = true;
        }
    }


    //When the target exits the  collision 
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //set the following condition to false
            following = false;
        }
    }
}
