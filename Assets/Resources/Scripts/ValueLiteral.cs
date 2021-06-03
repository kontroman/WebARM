using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueLiteral : Value
{
    public int value;

    public ValueLiteral(int _value) { value = _value; }

    public int Get(State _state)
    {
        return value;
    }
}
