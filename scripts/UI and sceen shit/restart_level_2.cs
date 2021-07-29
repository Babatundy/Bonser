using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class restart_level_2 : MonoBehaviour
{
 
    public void restart_2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
}
