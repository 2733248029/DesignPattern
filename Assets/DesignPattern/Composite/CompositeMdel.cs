using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CompositeModel;

namespace CompositeModel
{
    public class CompositeMdel : MonoBehaviour
    {
        private void Start()
        {
            Component theRoot = new Composite("Root");
            theRoot.Add(new Leaf("Leaf1"));
            theRoot.Add(new Leaf("Leaf2"));


            Component thiChild_1 = new Composite("Child1");
            thiChild_1.Add(new Leaf("Child_1.Leaf1"));
            thiChild_1.Add(new Leaf("Child_1.Leaf2"));
            theRoot.Add(thiChild_1);
            theRoot.Operation();
        }

    }
    public abstract class Component
    {
        protected string m_Value;
        public abstract void Operation();
        public virtual void Add(Component component)
        {
            Debug.LogWarning("子类没实现");
        }
        public virtual void Remove(Component component)
        {
            Debug.LogWarning("子类没实现");
        }
        public virtual Component GetChild(int index)
        {
            Debug.LogWarning("子类没实现");
            return null;
        }
    }
    public class Composite : Component

    {
        List<Component> m_Child = new List<Component>();
        public Composite(string value)
        {
            m_Value = value;
        }
        public override void Add(Component component)
        {
            m_Child.Add(component);
        }
        
        public override void Remove(Component component)
        {
            m_Child.Remove(component);
        }
        public override Component GetChild(int index)
        {
            return m_Child[index];
        }
        public override void Operation()
        {
            Debug.Log("Composite:" + m_Value);
            foreach (var item in m_Child)
            {
                item.Operation();
            }
        }
    }
    public class Leaf:Component
    {
        public Leaf(string value)
        {
            m_Value = value;
        }

        public override void Operation()
        {
            Debug.Log("Leaf{" + m_Value + "}执行Operation()");
        }
    }
}

