using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColleageSon_B : Colleage
{
    public ColleageSon_B(Mediator mediator) : base(mediator) { }
    public override void Request(string Message)
    {
        Debug.Log("ConlleageSon_B.Request:" + Message);
    }
    public void Action()
    {
        m_Mediator.SendMessage(this, "ColleageSonB发出通知");
       // m_Mediator.
    }
}
