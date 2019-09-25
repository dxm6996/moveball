using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove
{
    float Time { get; set; }
    void Move(GameObject obj, float time);
}
