using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaLisaHover : MonoBehaviour
{

    public GameObject textBox;

    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        //Debug.Log("Mouse is over GameObject.");

        if (Input.GetButtonDown("Click"))
        {
            textBox.SetActive(true);
        }

        

    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }


}
