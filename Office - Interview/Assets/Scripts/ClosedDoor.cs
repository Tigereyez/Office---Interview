using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedDoor : MonoBehaviour
{
    private Color originalColor; //we do the same thing as ColorChange.cs script 
    // Start is called before the first frame update
    void Start()
    {
        originalColor = this.transform.parent.GetComponent<Renderer>().material.color;
    }

 
    public void reset()
    {
        this.transform.parent.GetComponent<Renderer>().material.color = originalColor;
    }

    public void OnTriggerEnter(Collider other)  //will trigger when overlapping with another collider 
    {
        this.transform.parent.GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnTriggerExit(Collider other)   //will trigger when overlapp ends 
    {
        this.transform.parent.GetComponent<Renderer>().material.color = originalColor;
    }
}
