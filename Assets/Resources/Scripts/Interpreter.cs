using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interpreter
{
    public static Interpreter Instance { get; private set; }

    private bool debugMode = true;

    public Interpreter()
    {
        if (Instance != null) return;
        else Instance = this;
    }

    public void ChangeMode()
    {
        debugMode = !debugMode;
    }

    public void Execute(Memory mem)
    {
        if (State.Instance.R15.Get(State.Instance) > mem.commands.Count) return;

        if (debugMode)
        {
            mem.GetNext(State.Instance.R15.Get(State.Instance)).Apply(State.Instance);

            State.Instance.R15.Set(State.Instance, State.Instance.R15.Get(State.Instance) + 1);
        }
        else
        {

            while (State.Instance.R15.Get(State.Instance) < mem.commands.Count)
            {
                mem.GetNext(State.Instance.R15.Get(State.Instance)).Apply(State.Instance);

                State.Instance.R15.Set(State.Instance, State.Instance.R15.Get(State.Instance) + 1);
            }
        }
    }
}
