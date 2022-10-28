using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliverySys : MonoBehaviour
{
    int PackagesNo = 0;
    [SerializeField]  float TimeToDestroy = 0.5f;
    [SerializeField]  int PackageLimit = 5;
    [SerializeField] Color32 CarPaint = new Color32 (69,114,255,255);
    [SerializeField] Color32 CarPaintPacked = new Color32 (156,126,23,255);
    [SerializeField] Color32 CarPaintFull = new Color32 (154,2,0,255);
    SpriteRenderer SpriteRenderer;



    void Start() 
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other) 
        {
        
        

        }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Package" & PackagesNo <= PackageLimit-1)
         {
                Debug.Log("Package Picked up  !!! Go Deliver it To Post Office !!!");
                 ++PackagesNo;
                 SpriteRenderer.color = CarPaintPacked;

                Destroy(other.gameObject, TimeToDestroy);
                Debug.Log("Number of Packsges" + PackagesNo );
                     if (PackagesNo == PackageLimit)
                        {
                         Debug.Log("There are " + PackagesNo + " Packages on Car ! You have reached the limit !!! Deliver them !!!");
                         SpriteRenderer.color = CarPaintFull;  
                        }
         }


        if (other.tag == "Package" & PackagesNo == PackageLimit)
            {
            Debug.Log("Car is Full !!! Go Deliver your packages  To Post Office and then come back !!!");
            
         }




        if (other.tag == "PostOffice")
        {
           if (PackagesNo == 0)
                 {
                 Debug.Log("Sorry There aren't any packeges in the trunk !!! Go Find Some !!! ");
                 }
            if (PackagesNo == 1)
                 {
                 Debug.Log("Package Delivered !!!  Good Job !!! Go find other Packages!!!");
                 PackagesNo = 0;
                 SpriteRenderer.color = CarPaint;
                 }
        
            if (PackagesNo>1)
                {
                Debug.Log(PackagesNo + " Packages Delivered !!!  The More The better !!! Go find other Packages!!!");
                PackagesNo=0;
                SpriteRenderer.color = CarPaint;
                }

        }







    }




    
}
