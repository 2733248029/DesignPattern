using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Colleage
{
    protected Mediator m_Mediator = null;
    public Colleage(Mediator mediator)
    {
        this.m_Mediator = mediator;

    }
    /// <summary>
    /// Mediator通知
    /// </summary>
    /// <param name="Message"></param>
    public abstract void Request(string Message);
}
