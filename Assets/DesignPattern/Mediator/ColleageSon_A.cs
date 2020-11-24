using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColleageSon_A : Colleage
{
    public ColleageSon_A(Mediator mediator) : base(mediator) { }
    public override void Request(string Message)
    {
        Debug.Log("ConlleageSon_A.Request:" + Message);
    }
    public void Action()
    {
        m_Mediator.SendMessage(this, "ColleageSonA发出通知");
    }

}
