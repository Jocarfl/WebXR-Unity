using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class SampleBarAction : MonoBehaviour
{

    public Slider progressBar;

    float currentTime = 1f;
    float startingTime = 2f;


    public Image current_e;
    public Sprite happy_e;
    public Sprite normal_e;
    public Sprite sad_e;


    int maxTier=7;
    int statValue = 0;

    // Start is called before the first frame update
    void Start()
    {  
        currentTime = startingTime;
        progressBar.value = statValue;   
    }

    // Update is called once per frame
    void Update()
    {
        
         Debug.Log(progressBar.value);
        currentTime -=1 * Time.deltaTime;

        if(currentTime <= 0){
            progressBar.value += 1;
            currentTime = startingTime;
        }
        
        if(progressBar.value<=4){
            current_e.gameObject.GetComponent<Image>().sprite = happy_e;
        }

        if(progressBar.value>=4 && progressBar.value<=6){
            current_e.gameObject.GetComponent<Image>().sprite = normal_e;
        }

        if(progressBar.value>=6){
            current_e.gameObject.GetComponent<Image>().sprite = sad_e;
        }
        
        if(progressBar.value>=maxTier){
            progressBar.value = 0;
        }

    }

}
