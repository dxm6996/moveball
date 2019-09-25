using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableMovement : ScriptableObject
{
    public virtual IMove GetMover()
    {
        return null;
    }
}
