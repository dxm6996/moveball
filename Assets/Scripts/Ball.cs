using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour, IMovable
{
    private IEnumerator moveCoroutine;

    public void StartMove(ScriptableMovement scriptableMove)
    {
        if (moveCoroutine != null)
        {
            StopCoroutine(moveCoroutine);
        }
        moveCoroutine = MoveCoroutine(scriptableMove.GetMover());
        StartCoroutine(moveCoroutine);
    }

    public IEnumerator MoveCoroutine(IMove mover)
    {
        float t = 0f;
       
        while (t < mover.Time)
        {
            mover.Move(gameObject, t);
            t += Time.deltaTime;           
            yield return null;
        }
        mover.Move(gameObject, mover.Time);
    }  
}
