using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton
{
    public string Name { get; set; }
    public void TestFunction()
    {
        System.Console.WriteLine("This is a Singleton Function");
    }
    private static Singleton _instance;
    public static Singleton Instance
    {
        get
        {
            if(_instance == null)
            {
                
                Debug.Log("CreateSingleton");
                _instance = new Singleton();
            }
            return _instance;
        }
    }
    private Singleton() { }
}
