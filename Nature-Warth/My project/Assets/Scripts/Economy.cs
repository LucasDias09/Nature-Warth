using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
 private int goldBalance = 25; // Initial gold balance

    // Function to add gold to the player's balance 
    public void AddGold(int amount)
    {
        goldBalance += amount;
    }

    // Function to subtract gold from the player's balance
    public bool SubtractGold(int amount)
    {
        if (goldBalance >= amount)
        {
            goldBalance -= amount;
            return true; // Gold subtracted successfully
        }
        else
        {
            return false; // Insufficient gold balance
        }
    }

    // Function to get the player's current gold balance
    public int GetGoldBalance()
    {
        return goldBalance;
    }
}
