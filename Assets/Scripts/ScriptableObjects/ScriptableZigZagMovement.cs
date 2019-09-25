using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ZigZagMovement", menuName = "Custom/Movement/ZigZagMovement")]
public class ScriptableZigZagMovement : ScriptableMovement
{
    public float time;
    public float startPosX;
    public float endPosX;
    public int teethAmount;
    public float teethHeight;
   
    public override IMove GetMover()
    {
        return new ZigZagMovement(time, startPosX, endPosX, teethAmount, teethHeight);
    }
}
