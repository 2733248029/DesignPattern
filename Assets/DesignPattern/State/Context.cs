using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context : MonoBehaviour
{
    State m_State = null;
    public void Request(int value)
    {
        m_State.Handle(value);
    }
    public void SetState(State state)
    {
        Debug.Log("Context.SetState:" + state);
        m_State = state;
    }
}
