using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class getuser : MonoBehaviour
{
   public GameObject textDisplay;
    
    void Start()
    {
        string playername = PlayerPrefs.GetString("username");
    
        textDisplay.GetComponent<Text>().text = playername;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
