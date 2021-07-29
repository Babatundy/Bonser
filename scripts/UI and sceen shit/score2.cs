using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score2 : MonoBehaviour
{
    public Text scorep2;
    public static  int player2score ;
    

    public void p2score()
    {
            player2score++;
        
        // FindObjectOfType<the_winner>().da_winner();
    }
    public void p2score_slf()
    {
        player2score--;
        //FindObjectOfType<the_winner>().da_winner();
    }
    void Update()
    {
        scorep2.text = player2score.ToString();
       // FindObjectOfType<the_winner>().da_winner();
       
    }

}

