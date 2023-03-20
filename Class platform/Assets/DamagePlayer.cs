using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    PlayerManger playermanger;

    
    // Start is called before the first frame update
    void Start()
    {
        playermanger = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermanger>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2d(Collider2D collision)
    {
               
    }
}
