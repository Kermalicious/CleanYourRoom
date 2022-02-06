using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpWindow : MonoBehaviour
{
    //public GameObject example;

    //void Start()
    //{
    //    GameObject.Instantiate(example);
    //}

    // Displays the popup
    public void Show()
    {
        gameObject.SetActive(true);
    }

    //Closes the popup
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
