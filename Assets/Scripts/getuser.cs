using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getuser : MonoBehaviour
{
   public GameObject textDisplay;
   public GameObject timerDisplay;
   float timer = 0.0f;
 
    void Start()
    {
        string playername = PlayerPrefs.GetString("username");
    
        textDisplay.GetComponent<Text>().text = playername;
        
    }

    // Update is called once per frame
    void Update()
    {
    timer += Time.deltaTime;
    int seconds = (int)timer;
    timerDisplay.GetComponent<Text>().text = seconds.ToString() + " seconds passed";   
    }
}
