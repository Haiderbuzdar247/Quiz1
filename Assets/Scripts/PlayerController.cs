using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput ;
    public float speed;
    public GameObject firebullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.Space))
    {
        Instantiate ( firebullet , transform.position, firebullet.transform.rotation);
    }
    horizontalinput = Input.GetAxis("Horizontal");
    transform.Translate (Vector3.right * Time.deltaTime * speed * horizontalinput);

        
    }
}
