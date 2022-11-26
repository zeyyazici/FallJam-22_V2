using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class dialog : MonoBehaviour
{
  
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    void Start()
    {
        StartCoroutine(Type());
    }

        IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);


        }
    }
    // Start is called before the first frame update
    
        public void NextSentences()
    {
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
