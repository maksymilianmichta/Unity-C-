using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class CrashDetector : MonoBehaviour
{
   
    [SerializeField] string CrashMessage =  "Ouch!!!! My Head Hurts !!!" ;
    [SerializeField] float TimeToRestart = 1.5f;
    [SerializeField] ParticleSystem BloodEffect ;
    [SerializeField] AudioClip crashSFX;
    [SerializeField] bool Dead = false;
    



    IEnumerator OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Ground")
            {
                FindObjectOfType<PlayerControler>().NoControl();
                Debug.Log(CrashMessage);
                BloodEffect.Play();
                if(Dead==false)
                {
                GetComponent<AudioSource>().PlayOneShot(crashSFX);
                Dead = true;
                }
                yield return new WaitForSeconds(TimeToRestart);
                SceneManager.LoadScene(0); 
            } 
    }
}
