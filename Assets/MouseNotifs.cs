using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseNotifs : MonoBehaviour
{
    public void Start()
    {
        Debug.Log("butt");
    }
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }

    public void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }
}
