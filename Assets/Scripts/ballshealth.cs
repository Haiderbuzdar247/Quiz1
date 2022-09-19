using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ballshealth : MonoBehaviour
{   
    public TMP_Text ScoreFile1;
    
    static int scorepoint1 ;
    
     void Start()
    {
        
        scorepoint1 = Random.Range(3,9);
        ScoreFile1.text = scorepoint1.ToString();        
    }

   
    // Update is called once per frame
    void Update()
    {
       
       
        
    }

    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            scorepoint1--;
            ScoreFile1.text = scorepoint1.ToString();
            if(scorepoint1 <=0)
            Destroy(gameObject);
        }
       
    }
}
