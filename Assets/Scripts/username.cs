using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class username : MonoBehaviour
{
    public string playername;
    public GameObject inputField;
    public GameObject textDisplay;


    void Update(){
        playername = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = playername;
       
    }

    public void CreateUser(){
        PlayerPrefs.SetString("username",playername);
        string path = Application.dataPath + "/users/" + playername +".txt";
        if (!File.Exists(path)){
            File.WriteAllText(path,"");
        }


    }
}
