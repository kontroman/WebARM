using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mul : ICommand
{
    private string CommandName = "Mul";
    private MutableValue _first;
    private Value _second;
    private Value _third;

    internal Mul(MutableValue _value1, Value _value2, Value _value3)
    {
        this._first = _value1;
        this._second = _value2;
        this._third = _value3;
    }

    public void Apply(State _state)
    {
        _first.Set(_state, (_second.Get(_state) * _third.Get(_state)));
    }
}
