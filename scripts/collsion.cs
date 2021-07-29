using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class collsion : MonoBehaviour
{
    public Rigidbody2D ball;
    private string b_tag,b_goal;
    private bool pls_stop = true;
    public AudioSource colid;
    public Animator animator;
    public bool player_1 = false;
    public bool player_2 = false;
    public bool player_3 = false;
    public bool player_4 = false;

    /*private void FixedUpdate()
     {
         colid.enabled = false;
     }*/
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player1")
        {
            colid.enabled = false;
            ball.tag = "player1";
            b_tag= "player1";
            colid.enabled = true;
        }
        if (collision.gameObject.tag == "player2")
        {
            colid.enabled = false;
            ball.tag = "player2";
            b_tag = "player2";
            colid.enabled = true;

        }
        if (collision.gameObject.tag == "player3")
        {
            colid.enabled = false;
            ball.tag = "player3";
            b_tag = "player3";
            colid.enabled = true;
        }
        if (collision.gameObject.tag == "player4")
        {
            colid.enabled = false;
            ball.tag = "player4";
            b_tag = "player4";
            colid.enabled = true;
        }



        //pls don't wast ur time reading this spaghetti it just work 
        if (collision.gameObject.tag == "players1zone" && b_tag == "player1" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            pls_stop = false;
           
            FindObjectOfType<score1>().p1score_slf();
            FindObjectOfType<gamemaneger>().endgame();
          

        }

        if (collision.gameObject.tag == "players2zone"  && b_tag=="player1" && collision.gameObject.tag != "player" &&pls_stop==true)
        {
           // FindObjectOfType<desable_score>().desabling_score();
            player_1 = true;
            pls_stop = false;
            FindObjectOfType<score1>().p1score();
            FindObjectOfType<gamemaneger>().endgame();
            FindObjectOfType<particals2>().partical_activate2();
        }
        if (collision.gameObject.tag == "players3zone" && b_tag == "player1" && collision.gameObject.tag != "player" && pls_stop == true)
        { player_1 = true;
            pls_stop = false;
            FindObjectOfType<score1>().p1score();
            FindObjectOfType<gamemaneger>().endgame();
        
        }
        if (collision.gameObject.tag == "players4zone" && b_tag == "player1" && collision.gameObject.tag != "player" && pls_stop == true)
        {
         player_1 = true;
            pls_stop = false;
            FindObjectOfType<score1>().p1score();
            FindObjectOfType<gamemaneger>().endgame();
    
        }//szdf

        if (collision.gameObject.tag == "players1zone" && b_tag == "player2" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_2 = true;
            pls_stop = false;
            FindObjectOfType<score2>().p2score();
            FindObjectOfType<gamemaneger>().endgame();
            FindObjectOfType<particals1>().partical_activate1();
       
        }
        if (collision.gameObject.tag == "players2zone" && b_tag == "player2" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            pls_stop = false;
            
            FindObjectOfType<score2>().p2score_slf();
            FindObjectOfType<gamemaneger>().endgame();
         

        }
        if (collision.gameObject.tag == "players3zone" && b_tag == "player2" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_2 = true;
            
            pls_stop = false;
            FindObjectOfType<score2>().p2score();
            FindObjectOfType<gamemaneger>().endgame();
        
        }
        if (collision.gameObject.tag == "players4zone" && b_tag == "player2" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_2 = true;
            pls_stop = false;
            
            FindObjectOfType<score2>().p2score();
            FindObjectOfType<gamemaneger>().endgame();
        
        }//dzfaef
        if (collision.gameObject.tag == "players1zone" && b_tag == "player3" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_3 = true;
            pls_stop = false;
            FindObjectOfType<score3>().p3score();
            FindObjectOfType<gamemaneger>().endgame();
           
        }
        if (collision.gameObject.tag == "players2zone" && b_tag == "player3" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_3 = true;
            pls_stop = false;
            FindObjectOfType<score3>().p3score();
            FindObjectOfType<gamemaneger>().endgame();
       
        }
        if (collision.gameObject.tag == "players3zone" && b_tag == "player3" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            pls_stop = false;
            FindObjectOfType<score3>().p3score_slf();
            FindObjectOfType<gamemaneger>().endgame();
        

        }
        if (collision.gameObject.tag == "players4zone" && b_tag == "player3" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_3 = true;
            pls_stop = false;
            FindObjectOfType<score3>().p3score();
            FindObjectOfType<gamemaneger>().endgame();
         
        }//5665
        if (collision.gameObject.tag == "players1zone" && b_tag == "player4" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_4 = true;
            pls_stop = false;
            FindObjectOfType<score4>().p4score();
            FindObjectOfType<gamemaneger>().endgame();
       
        }
        if (collision.gameObject.tag == "players2zone" && b_tag == "player4" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_4 = true;
            pls_stop = false;
            FindObjectOfType<score4>().p4score();
            FindObjectOfType<gamemaneger>().endgame();
       
        }
        if (collision.gameObject.tag == "players3zone" && b_tag == "player4" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            player_4 = true;
            pls_stop = false;
            FindObjectOfType<score4>().p4score();
            FindObjectOfType<gamemaneger>().endgame();
          
        }
        if (collision.gameObject.tag == "players4zone" && b_tag == "player4" && collision.gameObject.tag != "player" && pls_stop == true)
        {
            pls_stop = false;
            FindObjectOfType<score4>().p4score_slf();
            FindObjectOfType<gamemaneger>().endgame();
          

        }//dad
        /*if(pls_stop==false)
        {
            FindObjectOfType<slow_motion>().slow_mo();
           
        }*/
        //nop
        if(player_1==true)
        {
            animator.enabled = true;
            animator.SetBool("player_1", true);
        }
        if (player_2 == true)
        {
            animator.enabled = true;
            animator.SetBool("player_2", true);
        }
        if (player_3 == true)
        {
            animator.enabled = true;
            animator.SetBool("player_3", true);
        }
        if (player_4 == true)
        {
            animator.enabled = true;
            animator.SetBool("player_4", true);
        }
    }
   
   
}
