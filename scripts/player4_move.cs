using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player4_move : MonoBehaviour
{
    
    public Rigidbody2D rb4;
   
    private Vector2 mo;
    public int rightforce, leftforce;
  
    void Update()
    {
        if (Input.GetKey("c"))
        {
            rb4.velocity = new Vector2(rightforce * Time.deltaTime, 0);
        }
        if (Input.GetKey("w"))
        {
            rb4.velocity = new Vector2(-leftforce * Time.deltaTime, 0);
        }
    }
}
