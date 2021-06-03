using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Memory
{
    public static Memory Instance { get; private set; }

    public List<ICommand> commands = new List<ICommand>();

    public Memory()
    {
        if (Instance != null) return;
        else Instance = this;
    }

    public ICommand GetNext(int value)
    {
        return commands[value];
    }

}
