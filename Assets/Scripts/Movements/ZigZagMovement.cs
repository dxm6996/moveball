using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZagMovement : IMove
{
    public float startPosX;
    public float endPosX;
    public int teethAmount;   
    public float teethHeight;   
    public float Time { get; set; }

    private float teethLength;
    private float teethLengthHalf;
    float t;
    float posX;
    float posY;
    float stage;
    float sector;
    float posInSector;

    public void Move(GameObject obj, float time)
    {
        t = Mathf.InverseLerp(0f, Time, time);
        posX = Mathf.Lerp(startPosX, endPosX, t);
        sector = Mathf.Ceil(posX/ teethLengthHalf);
        posInSector = (posX / teethLengthHalf) - (sector - 1f);
        if (sector % 2f == 0)
        {
            stage = Mathf.InverseLerp(1f, 0f, posInSector);
        }
        else
        {
            stage = Mathf.InverseLerp(0f, 1f, posInSector);
        }          
        posY = Mathf.Lerp(0f, teethHeight, stage);
        obj.transform.position = new Vector3(posX, posY, 0f);
    }

    public ZigZagMovement(float time, float startPosX, float endPosX, int teethAmount, float teethHeight)
    {
        this.startPosX = startPosX;
        this.endPosX = endPosX;
        this.teethAmount = teethAmount;
        this.teethHeight = teethHeight;
        Time = time;

        teethLength = Mathf.Abs(startPosX - endPosX)/(float)teethAmount;
        teethLengthHalf = teethLength / 2f;
    }
}
