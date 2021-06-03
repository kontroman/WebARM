using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : ICommand
{
    private string CommandName = "Mov";

    private MutableValue _first;
    private Value _second;

    internal Mov(MutableValue _value1, Value _value2)
    {
        this._first = _value1;
        this._second = _value2;
    }

    public void Apply(State _state)
    {
        _first.Set(_state, _second.Get(_state));
    }
}
