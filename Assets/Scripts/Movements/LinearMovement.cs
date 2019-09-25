using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement: IMove
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float Time { get; set; }

    float t;
    public void Move(GameObject obj, float time)
    {
        t = Mathf.InverseLerp(0f, Time, time);
        obj.transform.position = Vector3.Lerp(startPosition, endPosition, t);      
    }

    public LinearMovement(Vector3 startPos, Vector3 endPos, float t)
    {
        startPosition = startPos;
        endPosition = endPos;
        Time = t;
    }
}
