using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveR : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
        }
    }
}
