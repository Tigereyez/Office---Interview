using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject Player;

    public void TeleportPlayer() //when this is called by the TeleportUI.cs script it teleports the player to the object 
    {
        Player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z);
    }
}
