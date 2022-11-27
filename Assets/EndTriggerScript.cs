using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Canvas canvas1;
    void Start()
    {
        canvas1.enabled= false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {

        loadScene();

    }

  

    public void loadScene()
    {
        canvas1.enabled = true;

        Invoke("loadStation", 2);

       

       

    }

    void loadStation()
    {
        SceneManager.LoadScene(3);
    }

   
}
