using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeNote : MonoBehaviour
{

    public GameObject activeNote;

    
    private void OnTriggerEnter2D(Collider2D ghost)
    {

        if (ghost.CompareTag("Player"))
        {

            activeNote.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D ghost)
    {
        if (ghost.CompareTag("Player"))
        {

            activeNote.SetActive(false);
        }
    }

   

  

}