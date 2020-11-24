using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bridge
{
    public interface RenderEngine
    {
        void Render(string ObjName);
    }
    public class DirectX : RenderEngine
    {
        public void Render(string ObjName)
        {
            DXRender(ObjName);
        }
        public void DXRender(string name)
        {
            Debug.Log("DXRender:" + name);
        }
    }
    public class OpenGL : RenderEngine
    {
        public void Render(string ObjName)
        {
            GLRender(ObjName);
        }
        public void GLRender(string name)
        {
            Debug.Log("GLRender:" + name);
        }
    }
    public abstract class IShape
    {
        protected RenderEngine m_RenderEngine = null;
        public void SetRenderEngine(RenderEngine renderEngine)
        {
            m_RenderEngine = renderEngine;
        }
        public abstract void Draw();
    }
    public class Sphere : IShape
    {
        public override void Draw()
        {
            m_RenderEngine.Render("Draw");
        }
    }
    public class Cube : IShape
    {
        public override void Draw()
        {
            m_RenderEngine.Render("Cube");
        }
    }
}

