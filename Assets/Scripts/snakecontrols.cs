using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class snakecontrols : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.transform.position -= new Vector3(1f,0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.transform.position += new Vector3(1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.transform.position += new Vector3(0, 1f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.transform.position -= new Vector3(0, 1f);
        }
    }


    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "wall")
        {
            SceneManager.LoadScene(1);
        }else if(col.gameObject.tag == "food"){
            
        }
        

    }


}
