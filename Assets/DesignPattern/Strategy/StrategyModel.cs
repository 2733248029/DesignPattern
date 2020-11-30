using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Strategy;

namespace Strategy
{
    public class StrategyModel
    {
    }
    public class Context
    {
        Strategy m_Strategy =null;
        public void SetStrategy(Strategy strategy)
        {
            m_Strategy = strategy;
        }
        public void ActionStrategy()
        {
           if( m_Strategy==null)
           {
                Debug.LogError("m_Strategy is null!");
                return;
            }
            m_Strategy.AlgorithmInterface();

        }
    }
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }
    public class StrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("算法A");
        }
    }
    public class StrategyB : Strategy
    {
        public override void AlgorithmInterface()
            
           
        {
            Debug.Log("算法B");
        }
    }
    public class StrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Debug.Log("算法C");
        }
    }
    public interface Test
    {
        
         StrategyC StrategyC { get; set; }
        
    }
      public class a
    {
        string ac;
        int b;
    }

}


