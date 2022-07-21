using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 10;
    public void collisionHandler(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            score --;
            Debug.Log("your score is: " + score);
        }
    }
}
