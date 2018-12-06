using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace Tarea1_preg2
{
    public class Linea
    {
        public Color color = new Color();
        public Punto p0 = new Punto();
        public Punto p1 = new Punto();
        public float escala;

        public Linea(float pescala)
        {
            p0 = new Punto(0, 0);
            p1 = new Punto(0, 0);
            escala = pescala;
        }

        public Linea(Punto pp0, Punto pp1, float pescala)
        {
            p0 = pp0;
            p1 = pp1;
            escala = pescala;
        }

        public void DDA()
        {
            float dx = (p1.X - p0.X);
            float dy = (p1.Y - p0.Y);

            float pasos = (Math.Abs(dx) > Math.Abs(dy)) ? Math.Abs(dx) : Math.Abs(dy);
            float incX = dx / pasos;
            float incY = dy / pasos;

            float x = p0.X;
            float y = p0.Y;

            Gl.glColor3f(color.Rojo, color.Verde, color.Azul);

            for (int i = 0; i < pasos; i++)
            {
                SetPixel(x, y);
                x += incX;
                y += incY;
            }
        }

        public void SetPixel(float x, float y)
        {
            Gl.glPointSize(2);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(x / escala, y / escala);
            Gl.glEnd();
        }

    }

}
