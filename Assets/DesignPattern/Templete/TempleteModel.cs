using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleteModel
{

    
}
public abstract class Templete
{
    public void MainAction()
    {
        Operation1();
        Operation2();
        Operation3();
    }
    public abstract void Operation1();
    public abstract void Operation2();
    public abstract void Operation3();

}
public class PersonTemplete : Templete
{
    public override void Operation1()
    {
        Debug.Log("PersonTemplete_Operation1");
    }

    public override void Operation2()
    {
        Debug.Log("PersonTemplete_Operation2");
    }

    public override void Operation3()
    {
        Debug.Log("PersonTemplete_Operation3");
    }
}
