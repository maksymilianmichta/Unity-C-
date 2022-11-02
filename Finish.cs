using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    [SerializeField] string FinishCongrats =  "FINISHED!!!" ;
    [SerializeField] ParticleSystem FinishLineEffect ;
    [SerializeField] float TimeToRestart = 1.5f;

    IEnumerator OnTriggerEnter2D(Collider2D other) 
    {

        if(other.tag == "Player")
        {
            Debug.Log(FinishCongrats);
            FinishLineEffect.Play();
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(TimeToRestart); 
            SceneManager.LoadScene(0);
        }
    }

}
