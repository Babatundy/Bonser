using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score1 : MonoBehaviour
{
    public Text scorep1;
    public static int player1score;
   
    
    public void p1score()
    {
            player1score++;

    }
    public void p1score_slf()
    {
        player1score--;
        //FindObjectOfType<the_winner>().da_winner();
    }
    void Update()
    {
        scorep1.text = player1score.ToString();  
        
    }


}
