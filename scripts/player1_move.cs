using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1_move : MonoBehaviour
{
    public Rigidbody2D rb1;
  
    private Vector2 mo;
    public int upforce, downforce;
  

    

    void Update()
    {
        if (Input.GetKey("z"))
        {
            rb1.velocity = new Vector2(0, upforce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb1.velocity = new Vector2(0, -downforce * Time.deltaTime);
        }     
    }
}
