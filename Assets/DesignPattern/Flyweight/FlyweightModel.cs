using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlyweightModel
{
    public class FlyweightModelTest:MonoBehaviour
    {
        private void Start()
        {
            FlyweightFactor flyweightFactor = new FlyweightFactor();
            flyweightFactor.GetFlyweight("1", "共享组件1");
            flyweightFactor.GetFlyweight("2", "共享组件2");
            flyweightFactor.GetFlyweight("3", "共享组件3");
            Flyweight flyweight = flyweightFactor.GetFlyweight("1", "");
            unConcreteFlyweight unConcreteFlyweight = flyweightFactor.GetUnSharedFlyweight("不共享的信息1");

        }
    }
    public abstract class Flyweight
    {
        protected string m_Content;
        public Flyweight() { }

        public Flyweight(string Content)
        {
            this.m_Content = Content;
        }
        public string GetContent()
        {
            return m_Content;
        }
        public abstract void Operator();
    }
    public class ConcreteFlyweight : Flyweight
    {
        public ConcreteFlyweight(string Content) : base(Content) { }
        public override void Operator()
        {
            Debug.Log("ConcreteFlyweight.Conten{" + m_Content + "}");
        }

    }
    public class unConcreteFlyweight //: Flyweight
    {
        Flyweight m_Flyweight = null;
        string m_UnsharedContent;
        public unConcreteFlyweight(string Content)
        {
            m_UnsharedContent = Content;
        }
        public void SetFlyweight(Flyweight flyweight)
        {
            m_Flyweight = flyweight;
        }
        public void Operator()
        {
            string msg = string.Format("UnsharedCoincreteFlyweight.Content{{0}}", m_UnsharedContent);
            if (m_Flyweight != null)
            {
                msg += "包含了:" + m_Flyweight.GetContent();
                Debug.Log(msg);
            }
        }
    }
    public class FlyweightFactor
    {
        Dictionary<string, Flyweight> m_Flyweights = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string Key, string Content)
        {
            if (m_Flyweights.ContainsKey(Key))
            {
                return m_Flyweights[Key];
            }
            ConcreteFlyweight concreteFlyweight = new ConcreteFlyweight(Content);
            m_Flyweights[Key] = concreteFlyweight;
            Debug.Log("New Concreteweight Key[" + Key + "] Content[" + Content + "]");
            return concreteFlyweight;
        }
        public unConcreteFlyweight GetUnSharedFlyweight(string Content)
        {
            return new unConcreteFlyweight(Content);
        }
    }
}
