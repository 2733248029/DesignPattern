using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ConcreteStateB : State
{
    public ConcreteStateB(Context context) : base(context) { }
    public override void Handle(int value)
    {
        Debug.Log("StateB");
        if (value > 20)
        {
            m_Context.SetState(new ConcreteStateC(m_Context));
        }
    }
}