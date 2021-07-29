using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public static class the_winner
{
   
  
    public static void da_winner()
    {
           
            
         if(score1.player1score==6)
        {
      
            SceneManager.LoadSceneAsync(4);
        }

    
       
        if (score2.player2score == 6)
        {
     
            SceneManager.LoadSceneAsync(5);
        }

        if (score3.player3score == 6)
        {
      
            SceneManager.LoadSceneAsync(6);
        }
           
    
        if (score4.player4score == 6)
        {
     
            SceneManager.LoadSceneAsync(7);
        }
         
    
    }
}
