using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D thisRigidbody2D;
    public float speed = 7f;

    Vector2 moveDirection;


    public GameObject mazeEntrance;
    public float teleportimer = 5;
    public bool timeIsRunning = false;


    public GameObject KitchenNote;
    public bool noteTrigger;

    private void Start()
    {
        //timer is not counting down
        timeIsRunning = true;
    
    }


    void Update()
    {
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.y = Input.GetAxisRaw("Vertical");

        if ((GameObject.Find("crib").GetComponent<GameMaster>().points) == 3)
        {
            //timer goes off
            //new music maybe?
            //transport player to second level

            if (teleportimer > 0)
            {

                teleportimer -= Time.deltaTime;
            }
            else
            {

                teleportimer = 0;
                timeIsRunning = false;
            }

            if (teleportimer == 0)
            {

                thisRigidbody2D.transform.position = mazeEntrance.transform.position;
            }
    
        }
     
            
    }


}

