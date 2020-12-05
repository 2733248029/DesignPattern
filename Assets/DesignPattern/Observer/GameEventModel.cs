using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameEventModelTest
{
    public class GameEventModel : MonoBehaviour
    {
        private void Start()
        {
            Button button;
            EventCenter.AddListener(GameEvent.Killed, CallBackTest);
            EventCenter.AddListener<int>(GameEvent.Killed, CallBackTest_3);
            EventCenter.Broadcast(GameEvent.Killed);
        }
        void CallBackTest()
        {
            Debug.Log("传入的回调方法_1");
        }
        void CallBackTest_2()
        {
            Debug.Log("传入的回调方法_2");
        }
        void CallBackTest_3(int a)
        {
            Debug.Log("传入的回调方法_2");
        }
    }
    public enum GameEvent
    {
        Null = 0,
        Killed = 1,
        NewStage = 2
    }


    public class EventCenter
    {
        private static Dictionary<GameEvent, Delegate> m_EventTable = new Dictionary<GameEvent, Delegate>();
        private static void OnListenerAdding(GameEvent gameEvent,Delegate callBack)
        {
            if(!m_EventTable.ContainsKey(gameEvent))
            {
                m_EventTable.Add(gameEvent, null);
            }
            Delegate d = m_EventTable[gameEvent];
            if (d != null && d.GetType() != callBack.GetType())
            {
                throw new Exception(string.Format("尝试为事件{0}添加不同类型委托，当前事件委托为{0},添加事件委托类型为{1}", d.GetType(), callBack.GetType()));
            }
        }
        private static void OnListenerRemoving(GameEvent gameEvent,Delegate callBack)
        {
            if(m_EventTable.ContainsKey(gameEvent))
            {
                Delegate d = m_EventTable[gameEvent];
                if(d == null)
                {
                    throw new Exception(string.Format("移除监听错误:事件{0}没有对应的委托", gameEvent));
                }
                else if (d.GetType()!= callBack.GetType())
                {
                    throw new Exception(string.Format("移除监听错误：尝试为事件{0}移除不同类型的委托，当前委托类型为{1}，要移除的委托类型为{2}", gameEvent, d.GetType(), callBack.GetType()));
                }
            }
            else
            {
                throw new Exception(string.Format("移除监听错误：没有事件码{0}", gameEvent));
            }
           
        }
        private static void OnListenerRemoved(GameEvent gameEvent)
        {
            if(m_EventTable[gameEvent] ==null)
            {
                m_EventTable.Remove(gameEvent);
            }
        }
        public static void AddListener(GameEvent gameEvent,CallBack callback)
        {
            OnListenerAdding(gameEvent, callback);
            m_EventTable[gameEvent] = (CallBack)m_EventTable[gameEvent] + callback;
        }
        public static void AddListener<T>(GameEvent gameEvent, CallBack<T> callback)
        {
            OnListenerAdding(gameEvent, callback);
            m_EventTable[gameEvent] = (CallBack<T>)m_EventTable[gameEvent] + callback;
        }
        public static void RemoveListener(GameEvent eventType, CallBack callBack)
        {
            OnListenerRemoving(eventType, callBack);
            m_EventTable[eventType] = (CallBack)m_EventTable[eventType] - callBack;
            OnListenerRemoved(eventType);
        }
        public static void Broadcast(GameEvent gameEvent)
        {
            Delegate d;
            if(m_EventTable.TryGetValue(gameEvent,out d))
            {
                CallBack callBack = d as CallBack;
                if(callBack !=null)
                {
                    callBack();
                }
            }
            else
            {
                throw new Exception(string.Format("广播事件错误：事件{0}对应委托具有不同的类型", gameEvent));
            }
        }
    }
    public delegate void CallBack();
    public delegate void CallBack<T>(T a);
    public delegate void CallBack<T,X>(T a,X b);
    public delegate void CallBack<T,X,Y>(T a,X b,Y c);
    public delegate void CallBack<T,X,Y,Z>(T a,X b,Y c,Z d);
    public delegate void CallBack<T, X, Y, Z,W>(T a, X b, Y c, Z d,W e);
}

