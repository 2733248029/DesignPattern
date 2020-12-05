using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EventModelTest
{
    public class EventModel : MonoBehaviour
    {
        public Button button;
        private void Start()
        {
            EventManager.SubscribeEvent("按钮点击事件", Test);
            button.onClick.AddListener(Send);
        }
        public void Send()
        {
            EventManager.HandleEvent("按钮点击事件", this, new EventModelArgs("按钮点击了"));
        }
        public void Test(object sennder,EventModelArgs args)
        {
            Debug.Log("鼠标点击");
        }
    }
    public delegate void Handle(object sender,EventModelArgs args);
    public class EventModelArgs : EventArgs
    {
        public string Message;
        public EventModelArgs(string message)
        {
            this.Message = message;
        }
    }
    public class EventManager
    {
        private static Dictionary<string, Handle> m_EventList = new Dictionary<string, Handle>();
        public static void SubscribeEvent(string eventName,Handle handle)
        {
            m_EventList.Add(eventName, handle);
        }
        public static void  HandleEvent(string eventName,object sender,EventModelArgs eventModelArgs)
        {
            if(m_EventList.ContainsKey(eventName))
            {
                m_EventList[eventName](sender, eventModelArgs);
            }
        }
    }
    
}


