using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    Scorer scorer = new Scorer();
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 200f;
    void moveGiz()
    {
        float xVal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float yVal = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Translate(xVal, 0 , zVal);
        transform.Rotate(0, yVal, 0);
        scorerHandler();
    }
    
    private void OnCollisionEnter(Collision other)
    {
        scorer.collisionHandler(other);
    }

    void scorerHandler()
    {
        if(scorer.score == 0)
        {
            moveSpeed = 0f;
            rotateSpeed = 0f;
            Debug.Log("You lost honey :(");
        }
    }
    void Start()
    {
        Debug.Log("Start the game Giz :)");
    }

    // Update is called once per frame
    void Update()
    {
        moveGiz();
    }
}
