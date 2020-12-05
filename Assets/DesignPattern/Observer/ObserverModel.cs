using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverModel
{
    public class ObserverModel : MonoBehaviour
    {
        private void Start()
        {
            ConcreteSubject m_concreteSubject = new ConcreteSubject();
            ConcreteObserver1 concreteObserver1 = new ConcreteObserver1(m_concreteSubject);
            ConcreteObserver1 concreteObserver2 = new ConcreteObserver1(m_concreteSubject);
            m_concreteSubject.Attach(concreteObserver1);
            m_concreteSubject.Attach(concreteObserver2);
            concreteObserver1.Update();
            m_concreteSubject.SetState("1");
            concreteObserver1.Update();



        }

    }
    public abstract class Subject
    {
        List<Observer> m_Observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            m_Observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            m_Observers.Remove(observer);
        }
        protected void Notify()
        {
            foreach (Observer item in m_Observers)
            {
                item.Update();
            }
        }
    }
    public class ConcreteSubject:Subject
    {
        string m_SubjectState;
        public void SetState(string State)
        {
            m_SubjectState = State;
            Notify();
        }
        public string GetState()
        {
            return m_SubjectState;
        }
    }
    public abstract class Observer
    {
        public abstract void Update();
    }
    public class ConcreteObserver1:Observer
    {
        string m_ObjectState;
        ConcreteSubject m_ConcreteSubject = null;

        public ConcreteObserver1(ConcreteSubject concreteSubject)
        {
            m_ConcreteSubject = concreteSubject;
        }



        public override void Update()
        {
            Debug.Log("ConcreteObserver1.Update");
            m_ObjectState = m_ConcreteSubject.GetState();
        }
        public void ShowState()
        {
            Debug.Log("ConcreteObserver:Subject当前的主题:" + m_ObjectState);
        }
    }
    public class ConcreteObserver2 : Observer
    {
        string m_ObjectState;
        ConcreteSubject m_ConcreteSubject = null;

        public ConcreteObserver2(ConcreteSubject concreteSubject)
        {
            m_ConcreteSubject = concreteSubject;
        }
        public override void Update()
        {
            Debug.Log("ConcreteObserver2.Update");
            m_ObjectState = m_ConcreteSubject.GetState();
        }
        public void ShowState()
        {
            Debug.Log("ConcreteObserver:Subject当前的主题:" + m_ObjectState);
        }
    }
}

