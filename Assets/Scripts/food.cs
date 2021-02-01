using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public GameObject foodobject;
    public GameObject tail;

    public GameObject player;

    public GameObject enemy;

 
    void Start()
    {
        player = GameObject.Find("Player");
        enemy = GameObject.Find("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "player")
        {
           Destroy(foodobject);
           
           
        GameObject newtail = Instantiate(tail,new Vector3(player.transform.position.x-1,player.transform.position.y),Quaternion.Euler(0f,0f,45f));
           newtail.gameObject.name = "Tail";
           newtail.transform.parent = player.transform; 
           }

           if (col.gameObject.tag == "enemy")
        {
           Destroy(foodobject);
           
           
        GameObject newtail = Instantiate(tail,new Vector3(enemy.transform.position.x-1,enemy.transform.position.y),Quaternion.Euler(0f,0f,45f));
           newtail.gameObject.name = "Tail";
           newtail.transform.parent = enemy.transform; 
           }
           
        }
        

    }

