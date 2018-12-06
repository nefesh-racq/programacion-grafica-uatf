using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class ColorOpenGL
    {
        public float r, g, b;
        public ColorOpenGL(float red,float green,float blue) 
        {
            r = red;
            g = green;
            b = blue;
        }
        public ColorOpenGL()
        {
            r = g = b = 0.0f;
        }
    }
}
