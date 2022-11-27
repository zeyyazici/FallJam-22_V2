using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraHit : MonoBehaviour
{

    public Image crosshair;
    // Start is called before the first frame update
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            crosshair.color = Color.green;

            if(hit.transform.tag == "Door")
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                    hit.transform.GetComponent<DoorController>().CheckDoor();
            }

            if(hit.transform.tag == "Keypad")
            {
                if(Input.GetKeyDown(KeyCode.Mouse0))
                
                    hit.transform.GetComponent<KeyPad1>().OpenKeyUI();
                
            }
            else
            {
                crosshair.color = Color.white;
            }
        }
    }

    // Update is called once per frame
   
    
}
