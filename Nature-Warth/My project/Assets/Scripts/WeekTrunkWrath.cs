using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekTrunkWrath : MonoBehaviour
{
// Start is called before the first frame update
    public void Start()
    {
        
        // Get a reference to the Button component
        Button button = GetComponent<Button>();

        // Attach a method as an event listener for the button click
        button.onClick.AddListener(OnClick);
    }

    public int Money(){

        int currentGold = FindObjectOfType<Economy>().GetGoldBalance();

        return currentGold;
    }
 
    // Update is called once per frame
      void Update()
    {
        int liveGold = Money();

        // Get a reference to the Button component
        Button button = GetComponent<Button>();

        if(liveGold >= 5){
            button.interactable = true;
        }
        else
        {
            button.interactable = false;
        }
    }

    private void OnClick()
    {
        int liveGold = Money();
        int amountToSubtract = 5; 
        if (liveGold <= 4)
        {
            
        }
        else
        {
            FindObjectOfType<Economy>().SubtractGold(amountToSubtract);
        }

    }
}
