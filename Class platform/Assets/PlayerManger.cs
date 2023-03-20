using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManger : MonoBehaviour
{
    PlayerMovement playerMovement;
    public int coinCount;
    public int maxHealth;
    public int currentHealth;
    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        PauseGame();
    }
    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "Currency":
                coinCount++;
                return true;
            case "Speed+":
                playerMovement.SpeedPowerUp();
                return true;
            default:
                Debug.Log("Item tag or reference not set.");
                return false;

        }


    }


    public void takeDamage()
    {
        currentHealth -= 1;

    }

    public void PauseGame()
    {

        Time.timeScale = 1;
    }

}
