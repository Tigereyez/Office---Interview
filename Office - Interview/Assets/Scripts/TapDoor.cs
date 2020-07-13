using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapDoor : MonoBehaviour
{
    Animator anim;  //variable so we can use the door animations
    // Start is called before the first frame update
    void Start()
    {
        anim = this.transform.GetComponent<Animator>();     //select the animation of the object we want and not all animated objects 
    }

    public void Open()
    {
        anim.SetBool("isOpening", true);
    }

    public void Close()
    {
        anim.SetBool("isOpening", false);
    }

}
