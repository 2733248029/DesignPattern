using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleState : SceneState
{
    protected override string SceneStateName { get; set; }

    //游戏系统
    public BattleState(SceneController sceneController) : base(sceneController)
    {
        this.SceneStateName = "战斗界面";
    }
    public override void StateBegin()
    {
  
    }

    public override void StateEnd()
    {
    
    }

    public override void StateUpdate()
    {
       
    }
}
