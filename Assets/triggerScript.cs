using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerScript : MonoBehaviour
{
    public Canvas canvas1;
    void Start()
    {
        canvas1.enabled = false;
        canvas1 = GetComponent<Canvas>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.collider.CompareTag("Player"))
        {
            canvas1.enabled= true;
        }

        

    }

    private void OnCollisionExit(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            canvas1.enabled = false;
        }

    }
}
