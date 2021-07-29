using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score3 : MonoBehaviour
{
   public Text scorep3;
    public static int player3score ;
    
    public void p3score()
    {
       
            player3score++;
        //FindObjectOfType<the_winner>().da_winner();

    }
    public void p3score_slf()
    {
        player3score--;
        //FindObjectOfType<the_winner>().da_winner();
    }
    void Update()
    {
        scorep3.text = player3score.ToString();
       // FindObjectOfType<the_winner>().da_winner();
    }


}

