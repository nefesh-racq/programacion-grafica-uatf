using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Tarea1_preg3
{
    public class Punto
    {
        public float X, Y;
        public Color color = new Color();

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

        public Punto(float px, float pY, Color pcolor)
        {
            X = px;
            Y = pY;
            color = pcolor;
        }

        public void DibujarPunto(float escala)
        {
            Gl.glColor3f(color.Rojo, color.Verde, color.Azul);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(X / escala, Y / escala);
            Gl.glEnd();
        }
    }
}
