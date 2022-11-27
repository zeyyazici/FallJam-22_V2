using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad1 : MonoBehaviour
{

    public DoorController doorToOpen;
    public GameObject KeypadUI;

    public Text passwordText;

    public string password;

    private void Start()
    {
        passwordText.text = " ";
    }

    public void OpenKeyUI()
    {
        KeypadUI.SetActive(true);
        Cursor.visible = true;
    }

    public void KeyButton(string key)
    {
     
        Debug.Log(key);
        passwordText.text = passwordText.text + key;
    }

    public void ResetPassword()
    {
        Debug.Log("reset");
        passwordText.text = " ";
    }
    public void CheckPassword()
    {
        if(passwordText.text == password)
        {
            doorToOpen.isLocked = false;
            doorToOpen.CheckDoor();
            KeypadUI.SetActive(false);
        }
        else
        {
            ResetPassword();
        }
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    
}
