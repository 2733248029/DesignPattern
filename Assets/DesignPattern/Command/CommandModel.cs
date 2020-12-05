using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Command
{
    public class CommandModel : MonoBehaviour
    {
        private void Start()
        {
            Command command = new ConcreteCommand_1(new Function_1(), "命令1");
            Invoker invoker = new Invoker();
            invoker.AddCommand(command);
            invoker.AddCommand(command);
            invoker.AddCommand(command);
            invoker.AddCommand(command);
            invoker.AddCommand(command);
            invoker.ExcuteCommand();
        }
    }
    public class Function_1
    {
        public void Action(string Command)
        {
            Debug.Log("Function_1_Command:}" + Command);
        }
    }
    public class Function_2
    {
        public void Action(string Command)
        {
            Debug.Log("Function_2_Command:}" + Command);
        }
    }
    public abstract class Command
    {
        public abstract void Execute();
    }
    public class ConcreteCommand_1 : Command
    {
        Function_1 function_1 = null;
        string m_Command = "";
        public ConcreteCommand_1(Function_1 function_1, string Command)
        {
            this.function_1 = function_1;
            this.m_Command = Command;
        }
        public override void Execute()
        {
            function_1.Action(m_Command);
        }
    }
    public class ConcreteCommand_2 : Command
    {

        Function_2 function_2 = null;
        string m_Command = "";
        public ConcreteCommand_2(Function_2 function_2, string Command)
        {
            this.function_2 = function_2;
            this.m_Command = Command;
        }
        public override void Execute()
        {
            function_2.Action(m_Command);
        }
    }
    public class Invoker
    {
        List<Command> m_Commands = new List<Command>();
        public void AddCommand(Command command)
        {
            m_Commands.Add(command);
        }
        public void ExcuteCommand()
        {
            foreach (var item in m_Commands)
            {
                item.Execute();

            }
            m_Commands.Clear();
        }

    }
}
