using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundries : MonoBehaviour
{
    public static float leftSide = -6.7f;
    public static float rightSide = 6.7f;
    public float internalLeft;
    public float internalRight;

    
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
