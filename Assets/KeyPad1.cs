using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeyPad1 : MonoBehaviour
{

   
    public GameObject KeypadUI;

    public Text passwordText;

    public string password;
    private bool isChecking = false;

    private void Start()
    {
        passwordText.text = "";
    }

    public void OpenKeyUI()
    {
        KeypadUI.SetActive(true);
        Cursor.visible = true;
    }

    public void KeyButton(string key)
    {
        if(isChecking == true) { return; }

        Debug.Log(key);
        passwordText.text = passwordText.text + key;

        if(passwordText.text.Length == 3)
        {
            isChecking = true;
            Invoke("CheckPassword", 1f);
        }
        
    }

    public void ResetPassword()
    {
        Debug.Log("reset");
        passwordText.text = "";
    }
    public void CheckPassword()
    {
        isChecking = true;

        if(passwordText.text == password)
        {
           
            KeypadUI.SetActive(false);
            SceneManager.LoadScene(5);

        }
        else
        {
            ResetPassword();
        }

        isChecking = false;
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    
}
