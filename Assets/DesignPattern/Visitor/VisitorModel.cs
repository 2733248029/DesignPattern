using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VisitorModelTest
{
    public class VisitorModel : MonoBehaviour
    {
        private void Start()
        {
            ShapeContainer shapeContainer = new ShapeContainer();
            shapeContainer.AddShape(new Sphere());
            shapeContainer.RunVisitor(new DrawVisitor());
        }
    }
    public abstract class ShapeVisitor
    {
        public virtual void VisitSphere(Sphere sphere)
        {
        }
        public virtual void VisitCube()
        {

        }
        public virtual void VisitCylinder()
        {

        }
    }
    public class ShapeContainer
    {
        List<Shape> m_Shapes = new List<Shape>();
        public void AddShape(Shape shape)
        {
            m_Shapes.Add(shape);
        }
        public void RunVisitor(ShapeVisitor shapeVisitor)
        {
            foreach (var item in m_Shapes)
            {
                item.RunVisitor(shapeVisitor);
            }
        }
    }
    public abstract class Shape
    {
        public abstract void Draw();
        public abstract void RunVisitor(ShapeVisitor shapeVisitor);
    }
    public class Sphere:Shape
    {
        public override void Draw()
        {
            Debug.Log("SphereDraw");
        }

        public override void RunVisitor(ShapeVisitor shapeVisitor)
        {
            shapeVisitor.VisitSphere(this);
        }
    }
    public class DrawVisitor:ShapeVisitor
    {
        public override void VisitSphere(Sphere sphere)
        {
            sphere.Draw();
        }
    }
}

