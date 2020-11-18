using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    SceneController m_SceneController = new SceneController();
     void Awake()
    {
        //转换场景不会被删除
        GameObject.DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        //设置初始场景
        m_SceneController.SetState(new StartState(m_SceneController));
    }

    // Update is called once per frame
    void Update()
    {
        //TO DO StateUpdate;
    }
}
