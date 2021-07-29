using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class two_players_mode : MonoBehaviour
{
  
    public void enter_two_mode()
    {
        
        move_to_menu.nbr_players = 2;
        SceneManager.LoadScene(2);
    }
    
}
