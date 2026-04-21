using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed=15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    
    gameObject.transform. Translate(new Vector3(0f, 0f, speed) * Time.deltaTime);

if(Input.GetKey(KeyCode.D)){ 
gameObject.transform. Translate(new Vector3(5f, 0f,0f) *Time.deltaTime); 
}
if(Input.GetKey(KeyCode.A)) 
{
gameObject.transform. Translate(new Vector3(-5f, 0f,0f)* Time.deltaTime);
}  
    }
}
