using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Old
{
    public class Normal
    {

    }
    public class DirectX
    {
        public void DXRender(string name)
        {
            Debug.Log("DXRender" + name);
        }
    }
    public class OpenGL
    {
        public void GLRender(string name)
        {
            Debug.Log("GLRender" + name);
        }
    }
    public interface ISphere
    {
        void Draw();
    }
    public class SphereDX : ISphere
    {
        DirectX m_DirectX = new DirectX();
        public void Draw()
        {
            m_DirectX.DXRender("Sphere");
        }
    }
    public class SphereGL : ISphere
    {
        OpenGL m_OpenGL = new OpenGL();
        public void Draw()
        {
            m_OpenGL.GLRender("Sphere");
        }
    }
}
//..................................如果还要增加类或者增加方法



