using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Awake()
    {
        _ = new State();
        _ = new Memory();
        _ = new Interpreter();
    }

    public void DebugMode()
    {
        Interpreter.Instance.ChangeMode();
    }
}
