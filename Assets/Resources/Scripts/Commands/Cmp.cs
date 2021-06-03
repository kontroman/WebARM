using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cmp : ICommand
{
    private string CommandName = "Cmp";

    private Value _first;
    private Value _second;

    internal Cmp(MutableValue _value1, Value _value2)
    {
        this._first = _value1;
        this._second = _value2;
    }

    public void Apply(State _state)
    {
        _state.registers[_state.FLAG] = (_first.Get(_state) == _second.Get(_state)) ? 1 : 0;
    }
}
