using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportUI : MonoBehaviour
{
    public Image imgLoad;       //loading image
    public float lookTime = 2;  //time the player has to look for something to happen
    public int distOfRay = 10;  //max distance of ray
    private RaycastHit hit;     //ray hit

    bool gvrStatus;             //bool used with event system on teleport pads to start the timer 
    float gvrTimer;             //time player has look at interactable object

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgLoad.fillAmount = gvrTimer / lookTime;      //fills the loading image depending on how much time has passed
        }
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));

        if(Physics.Raycast(ray, out hit, distOfRay))
        {
            if(imgLoad.fillAmount == 1 && hit.transform.CompareTag("Teleport"))     //when image fully filled run the TeleportPlayer() comand in Teleport.cs
            {
                hit.transform.gameObject.GetComponent<Teleport>().TeleportPlayer();
            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgLoad.fillAmount = 0;
    }
}
