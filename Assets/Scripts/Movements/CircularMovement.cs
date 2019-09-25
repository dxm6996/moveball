using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : IMove
{
    public float Time { get; set; }
    public Vector3 centerPosition;
    public float radius;

    private float angle;
    private float targetAngle;
    private float startAngle;
    float t;
    float currentRadius;
    float posX;
    float posY;
    public void Move(GameObject obj, float time)
    {
        t = Mathf.InverseLerp(0f, Time, time);
        currentRadius = Mathf.Lerp(radius, 0f, t);
        angle = Mathf.Lerp(startAngle, targetAngle, t);
        posX = Mathf.Cos(angle) * currentRadius;
        posY = Mathf.Sin(angle) * currentRadius;
        obj.transform.position = new Vector3(-posX, posY, 0f) + centerPosition;
    }

    public CircularMovement(float time, float radius, Vector3 centerPosition, int lapsAmount)
    {
        Time = time;
        this.radius = radius;
        this.centerPosition = centerPosition;
        startAngle = 90f * (Mathf.PI / 180);
        targetAngle = ((360f * lapsAmount) + 90f) * (Mathf.PI / 180);       
    }
}
