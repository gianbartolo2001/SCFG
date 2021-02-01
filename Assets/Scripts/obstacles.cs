using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    // Start is called before the first frame updatepublic List<Transform> waypoints;

    public List<Transform> waypoints;
    public Transform aiMove;

    public bool loop = false;
    
    

    IEnumerator moveAI()
    {
        foreach(Transform t in waypoints){
            while(Vector3.Distance(aiMove.position,t.position)>0.1f){
                aiMove.position = Vector3.MoveTowards(aiMove.position,t.position,2f);
                yield return new WaitForSeconds(0.5f);
            }
        }

        yield return null;

    }

    IEnumerator moveAILoop()
    {
        foreach(Transform t in waypoints){
            while(Vector3.Distance(aiMove.position,t.position)>0.5f){
                aiMove.position = Vector3.MoveTowards(aiMove.position,t.position,2f);
                yield return new WaitForSeconds(0.5f);
            }
        }
        StartCoroutine(moveAILoop());
        yield return null;

    }

    void Start(){

        if(loop==true){
        
        StartCoroutine(moveAI());}
        else{
            StartCoroutine(moveAILoop());   
        }   
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    }