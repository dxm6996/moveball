using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UiController : MonoBehaviour
{
    [SerializeField]
    List<MoveInputButton> moveInputButtons = new List<MoveInputButton>();
    public static event Action<ScriptableMovement> MoveInputButtonEvent;

    private void Start()
    {
        foreach(var btnInput in moveInputButtons)
        {
            btnInput.button.onClick.AddListener(() => MoveInputButtonOnClick(btnInput.scriptableMove));
        }
    }

    private void MoveInputButtonOnClick(ScriptableMovement scriptableMove)
    {
        MoveInputButtonEvent.Invoke(scriptableMove);
    }
}
