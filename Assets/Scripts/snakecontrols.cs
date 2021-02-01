using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class snakecontrols : MonoBehaviour
{
    public Transform player;

    public int moves=0;
    
    public GameObject foodprefab;

    public bool hasspawned = false;
    
       public int tailcount = 0;
    void Start()
    {
        
    }
    IEnumerator generateFood(){
        
        float randomx = Mathf.Floor(Random.Range(-50f,50f));
        float randomy = Mathf.Floor(Random.Range(-50f,50f));

        Vector3 randompos = new Vector3(randomx,randomy);

        Instantiate(foodprefab, randompos, Quaternion.Euler(0f,0f,45f));
        
        
        
        yield break;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            player.transform.position -= new Vector3(2f,0);
            moves++;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.transform.position += new Vector3(2f, 0);
            moves++;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.transform.position += new Vector3(0, 2f);
            moves++;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.transform.position -= new Vector3(0, 2f);
            moves++;
        }

        if(moves %4==0 && hasspawned == false && moves!=0 &&moves<=81){
            hasspawned=true;
            StartCoroutine(generateFood());

            
            
        }else if(moves%4!=0){
            hasspawned=false;
        }
    }


    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "wall")
        {
            SceneManager.LoadScene(1);
        }else if(col.gameObject.tag == "exit"){
            if(tailcount>=6){
            SceneManager.LoadScene(2);
            }
            
        }
        else if(col.gameObject.tag == "food"){
            tailcount++;
        }
        

    }


}
