using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class RegisterDisplayser : MonoBehaviour
{
    public static RegisterDisplayser Instance { get; private set; }

    private Text registersText;

    private void Awake()
    {
        Instance = this;

        Init();
    }

    void Init()
    {
        registersText = GetComponent<Text>();
    }


    void Update()
    {
        registersText.text = "";

        foreach(KeyValuePair<MutableValue, int> pair in State.Instance.registers)
        {
            registersText.text = registersText.text + pair.Key.name + " " + pair.Value +"\n";
        }
    }

    public void Factorial5()
    {
        Memory.Instance.commands.Clear();

        Memory.Instance.commands.Add(new Mov(State.Instance.R0, new ValueLiteral(5)));
        Memory.Instance.commands.Add(new Mov(State.Instance.R1, new ValueLiteral(1)));
        Memory.Instance.commands.Add(new Mul(State.Instance.R1, State.Instance.R1, State.Instance.R0));
        Memory.Instance.commands.Add(new Add(State.Instance.R0, new ValueLiteral(-1)));
        Memory.Instance.commands.Add(new Cmp(State.Instance.R0, new ValueLiteral(0)));
        Memory.Instance.commands.Add(new Jmp(new ValueLiteral(-4)));
    }

    public void SumOfFirst10()
    {
        Memory.Instance.commands.Clear();

        Memory.Instance.commands.Add(new Mov(State.Instance.R0, new ValueLiteral(17)));
        Memory.Instance.commands.Add(new Mov(State.Instance.R1, new ValueLiteral(1)));
        Memory.Instance.commands.Add(new Add(State.Instance.R4, State.Instance.R1));
        Memory.Instance.commands.Add(new Cmp(State.Instance.R1, State.Instance.R0));
        Memory.Instance.commands.Add(new Add(State.Instance.R1, new ValueLiteral(1)));
        Memory.Instance.commands.Add(new Jmp(new ValueLiteral(-4)));
    }


    public void Execute()
    {
        Interpreter.Instance.Execute(Memory.Instance);
    }

    public void ResetRegisters()
    {
        State.Instance.registers.Clear();
        State.Instance.Init();
    }
}
