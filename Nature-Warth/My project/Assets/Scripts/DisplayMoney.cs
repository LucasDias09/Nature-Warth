using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayMoney : MonoBehaviour
{
    private TextMeshProUGUI goldText; 
    private Economy playerEconomy;
 
    private void Start()
    {
        // Get a reference to the Text component
        goldText = GetComponent<TextMeshProUGUI>();

        // Find and cache the PlayerEconomy script
        playerEconomy = FindObjectOfType<Economy>();
    }

    private void Update()
    {
        // Update the text value with the player's current gold balance
        goldText.text = "Gold: " + playerEconomy.GetGoldBalance();
    }
}
