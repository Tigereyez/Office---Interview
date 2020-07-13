using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDoor : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.transform.parent.GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isOpening", true);
    }

    public void OnTriggerExit(Collider other)
    {
        anim.SetBool("isOpening", false);
    }
}
