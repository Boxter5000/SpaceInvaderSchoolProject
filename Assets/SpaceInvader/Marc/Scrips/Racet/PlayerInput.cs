using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour , IInput
{
    float input;
    public string axisName = "Horizontal";

    void Update()
    {
        input = Input.GetAxisRaw(axisName);
    }

    public float GetInput()
    {
        return input;
    }
}
