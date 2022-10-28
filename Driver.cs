using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

       // int hitPoints = 20;\\fgh
        [SerializeField] float steerSpeed = 10f;
        [SerializeField] float moveSpeed = 10f;
        [SerializeField] float slowSpeed = 5f;
        [SerializeField] float fastSpeed = 15f;
        [SerializeField] Color32 CarPaintFast = new Color32 (229,20,0,255);
        [SerializeField] Color32 CarPaintOil = new Color32 (229,20,0,255);
         [SerializeField] Color32 CarPaint = new Color32 (69,114,255,255);
        [SerializeField]  float TimeToDestroy = 0.3f;
         SpriteRenderer SpriteRenderer;



    // Start is called before the first frame update
    void Start()
    {
    
        SpriteRenderer = GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; 
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime ;

        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);

        
           
    }
     IEnumerator OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "SpeedBoost")
         {
                Debug.Log("Speed Boost !!!");
                moveSpeed = moveSpeed + fastSpeed;
                SpriteRenderer.color = CarPaintFast;
                yield return new WaitForSeconds(3.0f);
                moveSpeed = moveSpeed - fastSpeed;
                SpriteRenderer.color = CarPaint;

                Destroy(other.gameObject, TimeToDestroy);
                
         }

        if (other.tag == "OilLeak")
         {
                Debug.Log("Spilled Oil Watch out next time!!!");
                moveSpeed = moveSpeed - slowSpeed;
                SpriteRenderer.color = CarPaintOil;
                yield return new WaitForSeconds(3.0f);
                moveSpeed = moveSpeed + slowSpeed;
                SpriteRenderer.color = CarPaint;

                //Destroy(other.gameObject, TimeToDestroy);
                
         }





    }
}
