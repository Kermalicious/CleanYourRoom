using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour
{
    public int[,] shopItems = new int[4,8];
    public int ownedItems;
    public int coins;
    public Text coinText;
    public bool bought;
    public bool added;

    void Start()
    {
        ownedItems = 0;
        coinText.text = coins.ToString();
        bought = false;
        added = false;

        //Initialize item ID
        for(int i = 1; i < 8; i++)
        {
            shopItems[1, i] = i;
        }

        //Initialize item Price
        shopItems[2, 1] = 100;
        shopItems[2, 2] = 75;
        shopItems[2, 3] = 10;
        shopItems[2, 4] = 20;
        shopItems[2, 5] = 20;
        shopItems[2, 6] = 20;
        shopItems[2, 7] = 15;

        //Initialize if they already own it
        for (int i = 3; i < 8; i++)
        {
            shopItems[3, i] = 0;
        }
    }

    public void Update()
    {
        coinText.text = coins.ToString();
    }

    public void earn(int amount)
    {
        Debug.Log("worked");
        coins += amount;
        coinText.text = coins.ToString();
    }

    public void BuyItem(int price)
    {
        if (coins >= price)
        {
            coins -= price;
            coinText.text = coins.ToString();
            bought = true;
            ownedItems++;
            added = false;
        }
    }

    public void setOwned(GameObject own)
    {
        if (bought)
        {
            own.SetActive(true);
        }
        bought = false;
    }

    public void setItem(GameObject item)
    {
        if (!added)
        {
            addItemToInventory(item);
            added = true;
        }
    }

    public void addItemToInventory(GameObject item)
    {
        float x = item.transform.position.x;
        float y = item.transform.position.y;
        float z = item.transform.position.z;
        item.SetActive(true);
        //middlecolumn x
        if(ownedItems%3 == 2)
        {
            x = x + 95;
            item.transform.position = new Vector3(x,y,z);
            
        }
        //rightcolumn x
        if (ownedItems % 3 == 0)
        {
            x = x + 190;
            item.transform.position = new Vector3(x, y, z);
        }
        //secondcolumn
        if (ownedItems > 3)
        {
            y = y - 80;
            item.transform.position = new Vector3(x, y, z);
        }

        //thirdcolumn
        if(ownedItems > 6)
        {
            y = y - 80;
            item.transform.position = new Vector3(x, y, z);
        }
    }
}
