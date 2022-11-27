using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle;
    public bool isLocked = false;

    bool isOpen = false;
    Quaternion starRot;
    
    // Start is called before the first frame update
    private void Start()
    {
        starRot = transform.rotation;
        
    }

    public void CheckDoor()
    {
        if (!isLocked)
            isOpen = !isOpen;
    }
    // Update is called once per frame
   private void Update()
    {
        Quaternion currentRot = transform.rotation;
        Quaternion newRot = Quaternion.Euler(transform.localEulerAngles.x, openAngle, transform.localEulerAngles.z);

        if (isOpen)

            transform.rotation = Quaternion.Lerp(currentRot, newRot, 0.2f);
        else
            transform.rotation = Quaternion.Lerp(currentRot, starRot, 0.2f);
        
    }
}
