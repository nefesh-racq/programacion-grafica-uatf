using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tao.OpenGl;

namespace Tarea4_preg1
{
    public class Circulo
    {
        private float escala;// = 1.0f;
        private float px, py;
        private Random r;

        public Circulo(Random r)
        {
            this.r = r;
            escala = (float)r.Next(1, 50) / 100;
            px = (float)r.Next(-100, 100) / 100;
            py = (float)r.Next(-100, 100) / 100;
        }

        public void dibujar()
        {
            Gl.glPushMatrix();
            Gl.glTranslatef(px, py, 0.0f);
            Gl.glScalef(escala, escala, 1.0f);
            circulo();
            Gl.glPopMatrix();
        }

        public void escalar()
        {
            escala -= 0.01f;

            if (escala < 0)
            {
                escala = (float)r.Next(1, 50) / 100;
                px = (float)r.Next(-100, 100) / 100;
                py = (float)r.Next(-100, 100) / 100;
            }
        }

        private void circulo()
        {
            float x, y, angulo;
            float tam = 0.1f;

            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(Gl.GL_POLYGON);
            for (int i = 0; i < 361; i++)
            {
                angulo = i * (float)Math.PI / 180.0f;
                x = (float)Math.Cos(angulo);
                y = (float)Math.Sin(angulo);

                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
        }

    }
}
