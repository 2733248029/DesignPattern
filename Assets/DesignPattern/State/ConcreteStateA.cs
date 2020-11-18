using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ConcreteStateA : State
{
    public ConcreteStateA(Context context) : base(context) { }
    public override void Handle(int value)
    {
        Debug.Log("StateA");
        if(value > 10)
        {
            m_Context.SetState(new ConcreteStateB(m_Context));
        }
    }
}

