using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "LinearMovement", menuName = "Custom/Movement/LinearMovement")]
public class ScriptableLinearMovement : ScriptableMovement
{
    public float time;
    public Vector3 startPosition;
    public Vector3 endPosition;

    public override IMove GetMover()
    {
       return new LinearMovement(startPosition, endPosition, time);
    }
}
