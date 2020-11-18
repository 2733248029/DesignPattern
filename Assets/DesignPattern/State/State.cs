using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected Context m_Context = null;
    public abstract void Handle(int value); 
    
    public State(Context context)
    {
        this.m_Context = context;
    }
}
