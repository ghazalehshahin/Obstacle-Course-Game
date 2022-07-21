using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{  
    //attributes and methods (position)  
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = 250f;
    public void getData()
    {
        Debug.Log("moveSpeed:" + moveSpeed + "**rotateSpeed:" + rotateSpeed);
    }
     public void setData(float mspeed, float rspeed)
    {
        moveSpeed = mspeed;
        rotateSpeed = rspeed;
    }


    //attributes and methods (score) 

    private int score = 10;
    public int getScore()
    {
        return score;
    }
    public void setScore(int sc)
    {
        score = sc;
    }
   

    //methods
    void moveGiz()
    {
        float xVal = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zVal = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float yVal = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Translate(xVal, 0 , zVal);
        transform.Rotate(0, yVal, 0);
        if(getScore() == 0)
        {
            setData(0f,0f);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit")
        {
            int sc = getScore();
            sc --;
            setScore(sc);
            Debug.Log("your is score is:" + getScore());
        }
    }
    

    //start and update methods
    void Start()
    {
        Debug.Log("Start the game Giz :)");
    }
    void Update()
    {
        moveGiz();
    }
}
