using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("enter");
    }
    private void OnCollisionStay2D(Collision2D other) 
    {
        Debug.Log("stay");
    }

    private void OnCollisionExit2D(Collision2D other) 
    {
        Debug.Log("exit");
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("enter");
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
        Debug.Log("stay");
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        Debug.Log("exit");
    }
}
