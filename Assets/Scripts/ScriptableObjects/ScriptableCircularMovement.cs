using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CircularMovement", menuName = "Custom/Movement/CircularMovement")]
public class ScriptableCircularMovement : ScriptableMovement
{
    public float time;
    public float radius;
    public int lapsAmount;
    public Vector3 centerPosition;

    public override IMove GetMover()
    {
        return new CircularMovement(time, radius, centerPosition, lapsAmount);
    }
}
