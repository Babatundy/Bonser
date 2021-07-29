using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class static_stop_itttt : MonoBehaviour
{
    

    public GameObject audio_destroy;

 
    public void static_inis()
    {
        
        score1.player1score = 0;
        score2.player2score = 0;
        score3.player3score = 0;
        score4.player4score = 0;

    }
    public void destroy_audio()
    {
       // AudioSource.DestroyImmediate(audio_destroy,true);
        FindObjectOfType<back_ground_music>().for_all.enabled = false;

    }
}
