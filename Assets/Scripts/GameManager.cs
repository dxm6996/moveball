using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject movableObject;
    private IMovable movable;

    private void Start()
    {
        movable = movableObject.GetComponent<IMovable>();
        if (movable == null)
        {
            Debug.LogError("Object have no IMovable interface");
        }
    }

    public void StartMove(ScriptableMovement scriptableMove)
    {
        movable.StartMove(scriptableMove);
    }

    private void OnEnable()
    {
        UiController.MoveInputButtonEvent += StartMove;
    }
    private void OnDisable()
    {
        UiController.MoveInputButtonEvent -= StartMove;
    }
}
