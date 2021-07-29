using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score4 : MonoBehaviour
{
     public Text scorep4;
    public static int player4score ;
    
    public void p4score()
    {
       
            player4score++;
       
    }
    public void p4score_slf()
    {
        player4score--;
        //FindObjectOfType<the_winner>().da_winner();
    }
    void Update()
    {
        scorep4.text = player4score.ToString();
      //  FindObjectOfType<the_winner>().da_winner();
    }

}

