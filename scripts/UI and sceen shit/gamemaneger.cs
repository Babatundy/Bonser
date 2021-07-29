using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemaneger : MonoBehaviour
{

    bool gameend = true;
    public float restart_time;
  
    public void endgame()
    {
        
    
        if(gameend== true)
        {
            gameend = false;
        }
        Invoke("restart", restart_time);
         the_winner.da_winner();// calling the function in order to check for the score

    }

   public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
}
