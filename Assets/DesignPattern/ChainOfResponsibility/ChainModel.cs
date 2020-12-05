using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chain
{
    public class ChainModel:MonoBehaviour
    {
        private void Start()
        {
            ConcreteHandler3 concreteHandler3 = new ConcreteHandler3(null);
            ConcreteHandler2 concreteHandler2 = new ConcreteHandler2(concreteHandler3);
            ConcreteHandler1 concreteHandler1 = new ConcreteHandler1(concreteHandler2);
            concreteHandler1.HandleRequest(10);
            concreteHandler1.HandleRequest(15);
            concreteHandler1.HandleRequest(20);
            concreteHandler1.HandleRequest(30);
        }
    }
    public abstract class Handler
    {
        protected Handler m_NextHandler = null;
        public Handler(Handler theNextHandler)
        {
            m_NextHandler = theNextHandler;
        }
        public virtual void HandleRequest(int cost)
        {
            if (m_NextHandler != null)
            {
                m_NextHandler.HandleRequest(cost);
            }
        }
    }
    public class ConcreteHandler1 : Handler
    {
        private int m_CostCheck = 10;
        public ConcreteHandler1(Handler theNextHandler) : base(theNextHandler) { }
        public override void HandleRequest(int cost)
        {
            if (cost <= m_CostCheck)
            {
                Debug.Log("ConcreteHandler1 Handle Sucess");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }
    public class ConcreteHandler2 : Handler
    {
        private int m_CostCheck = 20;
        public ConcreteHandler2(Handler theNextHandler) : base(theNextHandler) { }
        public override void HandleRequest(int cost)
        {
            if (cost <= m_CostCheck)
            {
                Debug.Log("ConcreteHandler2 Handle Sucess");
            }
            else
            {
                base.HandleRequest(cost);
            }
        }
    }
    public class ConcreteHandler3 : Handler
    {

        public ConcreteHandler3(Handler theNextHandler) : base(theNextHandler) { }
        public override void HandleRequest(int cost)
        {
            Debug.Log("ConcreteHandler3 Handle Sucess");

        }
    }
}

