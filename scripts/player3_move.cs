using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player3_move : MonoBehaviour
{

    public Rigidbody2D rb3;

    private Vector2 mo;
    public int rightforce, leftforce;
  
   
    void Update()
    {
     
      
        if (Input.GetKey("n"))
        {
           
            rb3.velocity = new Vector2(rightforce * Time.deltaTime, 0);
        }
        if (Input.GetKey("v"))
        {
            rb3.velocity = new Vector2(-leftforce * Time.deltaTime, 0);
        }
    }
}
