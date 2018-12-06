using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;

namespace Tarea2_preg1
{
    public class Points
    {
        private Color C;
        private float X, Y;

        public Points(float x, float y, Color c)
        {
            X = x;
            Y = y;
            C = c;
        }

        public void setPixel()
        {
            Gl.glColor3f(C.R, C.G, C.B);
            Gl.glPointSize(3.0f);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(0, 0);
                Gl.glVertex2f(X, Y);
            Gl.glEnd();
        }

    }
}
