using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // creates a location and reference for our player manger script
            Playermanger manger = collision.GetComponent<Playermanger>();
            if (manger)
            {
                bool pickedUp = manger.PickupItem(gameObject);


                if (pickedUp)
                {
                    Destroy(gameObject);

                }


            }

          
             

        }
    }
}
