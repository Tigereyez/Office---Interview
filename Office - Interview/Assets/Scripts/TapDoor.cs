using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapDoor : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.transform.GetComponent<Animator>();
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
