using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryModel
{

}
public abstract class Factory
{
    public abstract void FactoryMethod();

}
public class Factory_A : Factory
{
    public override void FactoryMethod()
    {
        Debug.Log("Create A");
    }
}
public class Factory_B : Factory
{
    public override void FactoryMethod()
    {
        Debug.Log("Create B");
    }
}
public class Factory_C : Factory
{
    public override void FactoryMethod()
    {
        Debug.Log("Create C");
    }
}