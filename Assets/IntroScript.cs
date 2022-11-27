using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class IntroScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Intro", 31);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Intro()
    {

       

        SceneManager.LoadScene(2);




    }


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        // Code to execute after the delay
        
    }
}
