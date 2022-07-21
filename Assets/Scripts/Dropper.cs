using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rigidBody;
    MeshRenderer meshRenderer;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    [SerializeField] float startTime = 5f;
    [SerializeField] float endTime = 15f;
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= startTime && Time.time <= endTime)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
            startTime*=2;
        }
        else if(Time.time >= endTime && Time.time <= startTime)
        {
            meshRenderer.enabled = false;
            rigidBody.useGravity = false;
            transform.Translate(0,15,0);
            endTime*=2;
        }
    }
}
