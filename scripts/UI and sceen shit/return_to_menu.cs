using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class return_to_menu : MonoBehaviour
{
   //this class is to move from 4players mode to the menu
    public void back_to_menu()
    {
        move_to_menu.nbr_players = 0;
        SceneManager.LoadSceneAsync(1);

        FindObjectOfType<back_ground_music>().for_all.enabled = true;
    }
    
    
}
