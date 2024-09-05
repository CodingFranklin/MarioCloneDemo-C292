using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    private Vector2 startPosition;
    private bool isMovingRight;

    [SerializeField] private float moveSpeed = 3;
    [SerializeField] private float offSet = 5;
    [SerializeField] private float rotationSpeed = 5;
    [SerializeField] private bool canMove = true;
    [SerializeField] private bool canRotate = true;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Debug.Log(startPosition);
    }

    // Update is called once per frame
    void Update()
    {
        LoopPlatform();
    }

    private void LoopPlatform()
    {
        if (canMove)
        {
            MovePlatform();
        }

        if (canRotate)
        {
            rotatePlatform();
        }
    }

    private void rotatePlatform()
    {
        transform.Rotate(0,0, rotationSpeed * Time.deltaTime);
    }

    private void MovePlatform()
    {
        if (transform.position.x >= startPosition.x + offSet)
        {
             isMovingRight = false;
        }
        if (transform.position.x <= startPosition.x - offSet)
        {
             isMovingRight = true;
        }


        if (isMovingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
}
