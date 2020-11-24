using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediatorCenter : Mediator
{
    ColleageSon_A m_ColleageSon_A = null;
    ColleageSon_B m_ColleageSon_B = null;
    public void SetColleageA(ColleageSon_A colleageSon_A)
    {
        m_ColleageSon_A = colleageSon_A;
    }
    public void SetColleageB(ColleageSon_B colleageSon_B)
    {
        m_ColleageSon_B = colleageSon_B;
    }

    public override void SendMessage(Colleage colleage, string Message)
    {
       if(m_ColleageSon_A == colleage)
        {
            m_ColleageSon_B.Request(Message);
        }
        if (m_ColleageSon_B == colleage)
        {
            m_ColleageSon_A.Request(Message);
        }
    }
}
