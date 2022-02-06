using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CreateText : MonoBehaviour
{
    public Text newText;
    public InventoryManager inventory;
    public GameObject test;

    void Start()
    {
        inventory = test.GetComponent<InventoryManager>();
    }

    void Update()
    {
        newText.text = inventory.coins.ToString();
    }
}
