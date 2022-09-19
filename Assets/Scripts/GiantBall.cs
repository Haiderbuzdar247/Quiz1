using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiantBall : MonoBehaviour
{
    public TMP_Text giantScore;
    //public GameObject[] smallballs;
    static int scoregiant;

    
    void Start()
    {
        scoregiant = Random.Range(10,16);
        giantScore.text = scoregiant.ToString();
    }

    void Update()
    {
        if (scoregiant == 0)
        {
            Destroy(gameObject);
           // Instantiate ( smallballs[Random.Range(0,smallballs.Length)], new Vector3  (Random.Range(-8,8), 4 ,0), transform.rotation);
        }
        
        
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Bullet"))
        {
            scoregiant--;
            giantScore.text = scoregiant.ToString();
        }
    }

}
