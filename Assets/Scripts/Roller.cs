using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{   
    [SerializeField] float val = 5f;
    bool isCollidedtoB1 = false;
    bool isCollidedtoB2 = false;
    void Update()
    {
        if(isCollidedtoB1 == false && isCollidedtoB2 == false)
        {
            transform.Translate(0,0,val*Time.deltaTime);
        }
        if(isCollidedtoB1 == true)
        {
            transform.Translate(0,0,val*Time.deltaTime);
        }
        if (isCollidedtoB2 == true)
        {
            transform.Translate(0,0,val*Time.deltaTime*-1);
        }
    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Bumper1")
        {
            isCollidedtoB1 = true;
            isCollidedtoB2 = false;
        }
        else if(other.gameObject.tag == "Bumper2")
        {
            isCollidedtoB1 = false;
            isCollidedtoB2 = true;
        }
    }
}
