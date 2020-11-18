using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SceneState
{
    protected SceneController m_SceneController;
    public SceneState(SceneController sceneController)
    {
        this.m_SceneController = sceneController;
    }
    protected abstract string SceneStateName { get; set; }
    public abstract void StateBegin();
    public abstract void StateEnd();
    public abstract void StateUpdate();
    public override string ToString()
    {
        return string.Format("当前场景名字:{0}", SceneStateName);
    }
}
