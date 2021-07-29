using UnityEngine;
using UnityEngine.SceneManagement;

public class move_to_menu : MonoBehaviour
{// to enter the menu affter seen the ruls
    public static int nbr_players = 0;
    public void enter_menu()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // this one is to re enter the game affter winning
    public void replay_affter_win()
    {
        SceneManager.LoadSceneAsync(1);
        FindObjectOfType<back_ground_music>().for_all.enabled = true;
       
    }
}
