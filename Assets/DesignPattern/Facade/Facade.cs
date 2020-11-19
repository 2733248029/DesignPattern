using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade
{
    public void Battle()
    {
        A a = new A();
        a.Battle();
    }
    public void Net()
    {
        B b = new B();
        b.Net();
    }
    public void Asset()
    {
        C c = new C();
        c.Asset();
    }
}
