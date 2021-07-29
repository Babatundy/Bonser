using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class for_players_mode : MonoBehaviour
{
   
    public void enter_for_mode()
    {
        move_to_menu.nbr_players = 4;       
        SceneManager.LoadScene(3);
    }
}
