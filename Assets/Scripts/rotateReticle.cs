using System.Security.Cryptography;
using UnityEngine;

public class rotateReticle : MonoBehaviour
{

    float speed = 5f;


    float height = .5f;

   Vector3 pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get the object current possition
        pos =  transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0, Space.World);
        
        // calculate the newY position
        float newY = Mathf.Sin(Time.time * speed)*height+pos.y;
        //set the calculated newY position to object
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        
        
        
        
      
    }
}
