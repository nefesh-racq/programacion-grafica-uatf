using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Tarea1_preg2
{
    public class Punto
    {
        public float X, Y;

        public Punto()
        {
            X = 0;
            Y = 0;
        }

        public Punto(float px, float pY)
        {
            X = px;
            Y = pY;
        }

        public void DibujarPunto()
        {
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(X, Y);
            Gl.glEnd();
        }

    }

}
