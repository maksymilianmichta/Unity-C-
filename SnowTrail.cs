using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrail : MonoBehaviour
{

[SerializeField] ParticleSystem snowTrail ;



    void OnCollisionEnter2D(Collision2D other) 
        {
            snowTrail.Play();    
        }

    void OnCollisionExit2D(Collision2D other) 
    {
        snowTrail.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        snowTrail.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
