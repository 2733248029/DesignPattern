using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ConcreteStateC : State
{
    public ConcreteStateC(Context context) : base(context) { }
    public override void Handle(int value)
    {
        Debug.Log("StateC");
        if (value > 30)
        {
            m_Context.SetState(new ConcreteStateA(m_Context));
        }
    }
}