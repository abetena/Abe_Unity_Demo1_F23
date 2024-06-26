using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOrReturn : MonoBehaviour
{
    //Where the enemy returns too
    public Transform HomeBase;
    //The player
    public Transform Player;
    //The enemy speed
    public float speed = 1.0f;

    private UIScript ui;

    private Transform target;
    private Rigidbody2D rb;
    private bool _stop = false;

    // Start is called before the first frame update
    void Start()
    {
        //Grab the rb
        rb = GetComponent<Rigidbody2D>();
        //set player as Target from the the start
        targetPlayer();

        ui = FindObjectOfType<UIScript>();
        Debug.Log(this.gameObject.name + " has an UI");
    }

    // FixedUpdate is called after each physics calculations
    private void FixedUpdate()
    {
        //If both home base and player have been defined
        if (HomeBase && Player)
        {
            //If the stop boolean is false, chase whichever target is set
            if (!_stop && !ui.gameOver)
            {
                rb.MovePosition(Vector2.Lerp(transform.position, target.position, Time.fixedDeltaTime * speed));
            }
        }

    }

    //Target the player
    public void targetPlayer()
    {
        target = Player;
    }

    //Target the Home Base
    public void TargetBase()
    {
        target = HomeBase;
    }

    //Switch enemy movement on or off
    public void StopPlayEnemy()
    {
        _stop = !_stop;
    }

    //Change speed
    public void SwitchSpeed (float _newSpeed)
    {
        speed = _newSpeed;
    }

}
