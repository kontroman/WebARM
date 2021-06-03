using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MutableValue : Value
{
    public string name;

    public MutableValue(string _name)
    {
        name = _name;
    }

    public int Get(State _state)
    {
        return _state.registers[this];
    }

    public void Set(State _state, int value)
    {
        _state.registers[this] = value;
    }
}
