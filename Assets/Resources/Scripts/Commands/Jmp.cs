using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jmp : ICommand
{
    private string CommandName = "Jmp";
    private Value _first;

    internal Jmp(Value _value)
    {
        this._first = _value;
    }

    public void Apply(State _state)
    {
        if (_state.FLAG.Get(_state) == 0)
            _state.R15.Set(_state, (_state.R15.Get(_state) + _first.Get(_state)));
    }
}
