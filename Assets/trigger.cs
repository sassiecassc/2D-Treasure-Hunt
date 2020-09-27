using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private GameMaster gm;

   void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<GameMaster>();
       
     
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("stuffed animal"))
        {
            gm.points += 1;

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}
