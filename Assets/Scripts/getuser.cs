using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
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
    PlayerPrefs.SetString("score",seconds.ToString());
    timerDisplay.GetComponent<Text>().text = PlayerPrefs.GetString("score") + " seconds passed";
    
   
        
    }

}
