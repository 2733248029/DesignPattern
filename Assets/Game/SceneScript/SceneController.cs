using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController
{
    private SceneState m_SceneState;
    public void SetState(SceneState m_SceneState)
    {
        m_SceneState.StateEnd();
        this.m_SceneState = m_SceneState;
        //TO DO卸载场景

        //TO DO载入场景
        m_SceneState.StateUpdate();
    }
}
