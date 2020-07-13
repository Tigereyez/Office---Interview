using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is used with the event system on the doors to highlight them when the player is looking at them or clicking on them as well as reseting the color when the player looks away

public class ColorChange : MonoBehaviour
{
    private Color originalColor;    //variable to retain the color we are about to overwrite

    void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;    //save the default color
    }

    public void reset()
    {
        GetComponent<Renderer>().material.color = originalColor;    //applies the default color
    }

    public void blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;       //changes the first material to blue 
    }

    public void green()
    {
        GetComponent<Renderer>().material.color = Color.green;      //changes the first material to green
    }
}
