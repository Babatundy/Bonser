using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2_move : MonoBehaviour
{
    public Rigidbody2D rb2;
  
    private Vector2 mo;
    public int upforce, downforce;
    


  
    
    void Update()
    {
        if (Input.GetKey("p"))
        {
            rb2.velocity = new Vector2(0, upforce * Time.deltaTime);
        }
        if (Input.GetKey("m"))
        {
            rb2.velocity = new Vector2(0, -downforce * Time.deltaTime);
        }     
    }
}
