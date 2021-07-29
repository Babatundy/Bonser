using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class restart_level_4 : MonoBehaviour
{
   public void restart_4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
