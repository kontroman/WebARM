using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State 
{
    public static State Instance { get; private set; }

    //общие регистры R0ЦR12;
    //указатель стека SP, он же регистр R13;
    //регистр св€зи LR, он же регистр R14;
    //счЄтчик команд PC, он же регистр R15.

    internal Dictionary<MutableValue, int> registers = new Dictionary<MutableValue, int>();

    internal MutableValue R0 = new MutableValue("R0");
    internal MutableValue R1 = new MutableValue("R1");
    internal MutableValue R2 = new MutableValue("R2");
    internal MutableValue R3 = new MutableValue("R3");
    internal MutableValue R4 = new MutableValue("R4");
    internal MutableValue R5 = new MutableValue("R5");
    internal MutableValue R6 = new MutableValue("R6");
    internal MutableValue R7 = new MutableValue("R7");
    internal MutableValue R8 = new MutableValue("R8");
    internal MutableValue R9 = new MutableValue("R9");
    internal MutableValue R10 = new MutableValue("R10");
    internal MutableValue R11 = new MutableValue("R11");
    internal MutableValue R12 = new MutableValue("R12");
    internal MutableValue R13 = new MutableValue("R13");
    internal MutableValue R14 = new MutableValue("R14");
    internal MutableValue R15 = new MutableValue("R15");
    internal MutableValue FLAG = new MutableValue("FLAG");

    public State()
    {
        if (Instance != null) return;
        else Instance = this;

        Init();
    }

    public void Init()
    {
        registers.Add(R0, 0);
        registers.Add(R1, 0);
        registers.Add(R2, 0);
        registers.Add(R3, 0);
        registers.Add(R4, 0);
        registers.Add(R5, 0);
        registers.Add(R6, 0);
        registers.Add(R7, 0);
        registers.Add(R8, 0);
        registers.Add(R9, 0);
        registers.Add(R10, 0);
        registers.Add(R11, 0);
        registers.Add(R12, 0);

        registers.Add(R13, 0);

        registers.Add(R14, 0);

        registers.Add(R15, 0);

        registers.Add(FLAG, 0);
    }

    internal int Get(MutableValue address)
    {
        return registers[address];
    }

    internal void Set(MutableValue address, int value)
    {
        if(!registers.ContainsKey(address))
            throw new System.Exception();

        registers[address] = value;
    }
}
