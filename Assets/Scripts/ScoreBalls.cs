using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreBalls : MonoBehaviour
{
    
    
    public GameObject[] gameBalls;
    public GameObject giantBall;

    public int startdelay ;
    public int gapdelay;

    void Start()
    {
        InvokeRepeating("spawnballsgiant" , 2 , 10);
        InvokeRepeating("spawnballs" , startdelay , gapdelay); 
 
    }

    
    void spawnballs()
    {
       
        Instantiate (gameBalls[Random.Range(0,gameBalls.Length)], new Vector3  (Random.Range(-8,8), 4 ,0) , transform.rotation);
    }
    void spawnballsgiant()
    {
        Instantiate (giantBall, new Vector3  (Random.Range(-8,8), 4 ,0) , transform.rotation);
    }

   
}
