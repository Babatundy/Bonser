using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class return_to_menu2 : MonoBehaviour
{
    //this class is to move from 2players mode to the menu
  
    public void back_to_menu2()
    {
        SceneManager.LoadSceneAsync(1);
        FindObjectOfType<back_ground_music>().for_all.enabled = true;
    }
   

}
