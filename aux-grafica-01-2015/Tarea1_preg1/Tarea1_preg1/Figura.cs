using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace Tarea1_preg1
{
    public class Figura
    {
        public void Dibujar()
        {
            var aleatorio = new Random();
            var x = -0.9f;
            var y = 0.9f;

            while (x < 1)
            {
                while (y > -1)
                {
                    Gl.glPointSize(aleatorio.Next(1, 50));
                    Gl.glColor3f(aleatorio.Next(1, 10) / 10.0f,
                                 aleatorio.Next(1, 10) / 10.0f,
                                 aleatorio.Next(1, 10) / 10.0f
                                 );

                    SetPixel(x, y);
                    y -= 0.2f;
                }

                x += 0.2f;
                y = 0.9f;
            }
        }

        public void SetPixel(float x, float y)
        {
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(x, y);
            Gl.glEnd();
        }
    }

}
