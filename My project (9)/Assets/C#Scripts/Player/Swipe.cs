using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.U2D;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private float speed = 0.01f;
    private Touch touch;
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                if(this.gameObject.transform.position.x > LevelBoundries.leftSide)
                {
                    transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y, transform.position.z);
                }
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed, transform.position.y,transform.position.z);
            }
        }
    }
}

