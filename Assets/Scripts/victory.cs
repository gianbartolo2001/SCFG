using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class victory : MonoBehaviour
{
    public string playername;

    public string score;
    public GameObject textDisplay;
    public GameObject scoreDisplay;



    void Update(){
        

        string playername = PlayerPrefs.GetString("username");
        string score = PlayerPrefs.GetString("score");
        textDisplay.GetComponent<Text>().text = playername;
        scoreDisplay.GetComponent<Text>().text = score;
       
    }

    


    }

