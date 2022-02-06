using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInButtons : MonoBehaviour
{
    public int pressed = 0;
    public InventoryManager inventory;
    public bool logged;

    public void dailyLog()
    {
        if(pressed%2 == 0)
        {
            gameObject.SetActive(true);
            logged = true;
        }
        else
        {
            gameObject.SetActive(false);
            logged = false;
        }
        pressed++;
    }

    public void pastLog()
    {
        if (pressed % 2 == 0)
        {
            gameObject.SetActive(true);
            logged = true;
        }
        else
        {
            gameObject.SetActive(false);
            logged = false;
        }
        pressed++;
    }

    public void displayCoins()
    {
        if (pressed % 2 == 0)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
        pressed++;
    }

    

    public void giveCoins()
    {
        if(logged)
        {
            gameObject.GetComponent<InventoryManager>().coins += 5;
        }
    }
}
