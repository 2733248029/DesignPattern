using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderModel
{

}
public abstract class Builder
{
    public abstract void BuildPart1(Product theProduct);
    public abstract void BuildPart2(Product theProduct);
}
public class BuilderA : Builder
{
    public override void BuildPart1(Product theProduct)
    {
        theProduct.AddPart("A_Part1");
    }

    public override void BuildPart2(Product theProduct)
    {
        theProduct.AddPart("A_Part2");
    }
}
public class Director
{
    private Product m_Product;
    public void Construct(Builder builder)
    {
        m_Product = new Product();
        builder.BuildPart1(m_Product);
        builder.BuildPart2(m_Product);
        
    }
}
public class Product
{
    private List<string> m_Part = new List<string>();
    public void AddPart(string message)
    {
        m_Part.Add(message);
    }
    public void ShowProduct()
    {
        foreach (var item in m_Part)
        {
            Debug.Log(item);
        }
    }
}
