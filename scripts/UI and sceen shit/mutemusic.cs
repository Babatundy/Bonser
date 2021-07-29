using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class mutemusic : MonoBehaviour
{
    public AudioSource mutee;
    int cpt = 0;
    public void mute_music()
    {
        
        if(cpt%2!=0)
        {
        cpt++;
            mutee.enabled = true;
        }
        else
        {
            cpt++;
            mutee.enabled = false;
        }
    }
}
