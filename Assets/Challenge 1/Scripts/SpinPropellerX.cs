using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpinPropellerX : MonoBehaviour
{
    
    //Create our propellerRotationSpeed variable
    private float rotationSpeed = 100f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        // spin the propeller
        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
