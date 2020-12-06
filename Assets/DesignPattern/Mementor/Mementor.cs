using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MementorTest
{
    public class Mementor : MonoBehaviour
    {

        Originator originator;
        private void Start()
        {
            //--------------First Test
            originator = new Originator();
            originator.SetInfo("1");
            originator.ShowInfo();
            Memento memento = originator.CreateMemento();
            originator.SetInfo("2");
            originator.ShowInfo();
            originator.SetMemento(memento);
            originator.ShowInfo();

            //-------------Second Test
            Debug.Log("//-------------Second Test");
            originator = new Originator();
            Caretaker caretaker = new Caretaker();
            originator.SetInfo("Version1Data");
            originator.ShowInfo();
            caretaker.AddMemento("Version1", originator.CreateMemento());
            originator.SetInfo("Version2Data");
            originator.ShowInfo();
            caretaker.AddMemento("Version2", originator.CreateMemento());
            originator.SetInfo("Version3Data");
            originator.ShowInfo();
            caretaker.AddMemento("Version3", originator.CreateMemento());
            originator.SetMemento(caretaker.GetMemento("Version2"));
            originator.ShowInfo();



        }
    }
    public class Originator
    {
        string data;
        public void SetInfo(string data)
        {
            this.data = data;
        }
        public void ShowInfo()
        {
            Debug.Log("data:" + data);
        }
        public Memento CreateMemento()
        {
            Memento newMemento = new Memento();
            newMemento.Data = data;
            return newMemento;
        }
        public void SetMemento(Memento memento)
        {
            data = memento.Data;
        }
    }
    public class Memento
    {
       public string Data { get; set; }

    }
    public class Caretaker
    {
        Dictionary<string, Memento> m_Mementos = new Dictionary<string, Memento>();
        public void AddMemento(string Version,Memento memento)
        {
            if(m_Mementos.ContainsKey(Version)==false)
            {
                m_Mementos.Add(Version, memento);
            }
            else
            {
                m_Mementos[Version] = memento;
            }
        }
        public Memento GetMemento(string version)
        {
            if (!m_Mementos.ContainsKey(version)) return null;
                return m_Mementos[version];
            

        }
    }
}

