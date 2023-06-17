using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amoutCountTrunk : MonoBehaviour
{
 private int amoutCout = 0; // Initial amout balance

    // Function to add amout to the player's balance 
    public void AddAmout(int amount)
    {
        amoutCout += amount;
    }

    // Function to subtract amout from the player's balance
    public bool SubtractAmout(int amount)
    {
        if (amoutCout >= amount)
        {
            amoutCout -= amount;
            return true; // amout subtracted successfully
        }
        else
        {
            return false; // Insufficient amout balance
        }
    }

    // Function to get the player's current amout balance
    public int GetAmoutBalance()
    {
        return amoutCout;
    }
}
