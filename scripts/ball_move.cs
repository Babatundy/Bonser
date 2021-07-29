using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    public Rigidbody2D ball;
    public int starting_ball_force;
    public string ball_tag;
    private bool game_has_started = true;
    
     void FixedUpdate()
    {
        if(game_has_started==true)
        {
            if (Input.GetKey("p") || Input.GetKey("m"))
            {
                ball.AddForce(new Vector2(starting_ball_force * Time.deltaTime, 0), ForceMode2D.Impulse);
                game_has_started = false;
            }
            if (Input.GetKey("z") || Input.GetKey("s"))
            {
                ball.AddForce(new Vector2(-starting_ball_force * Time.deltaTime, 0), ForceMode2D.Impulse);
                game_has_started = false;
            }
            if ((Input.GetKey("w") || Input.GetKey("c")) && move_to_menu.nbr_players == 4)
            {
               
                ball.AddForce(new Vector2(0, starting_ball_force * Time.deltaTime), ForceMode2D.Impulse);
                game_has_started = false;
            }
            if ((Input.GetKey("n") || Input.GetKey("v")) && move_to_menu.nbr_players == 4)
            {
               
                ball.AddForce(new Vector2(0, -starting_ball_force * Time.deltaTime), ForceMode2D.Impulse);
                game_has_started = false;
            } 
        }
       
    }
    
}
