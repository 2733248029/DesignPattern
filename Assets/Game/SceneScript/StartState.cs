using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : SceneState
{
    protected override string SceneStateName { get; set; }
    public StartState(SceneController sceneController) : base(sceneController)
    {
        this.SceneStateName = "开始界面";
    }
    public override void StateBegin()
    {
       
    }

    public override void StateEnd()
    {
       
    }

    public override void StateUpdate()
    {
        m_SceneController.SetState(new MainMenuState(m_SceneController));
    }
}
