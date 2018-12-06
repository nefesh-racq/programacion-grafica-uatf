using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta1
    {
    /* dibuja la figura y pasa el color para los triangulos de la figuraConpuesta*/
        public void dibujar()
        {
           figuraCompuesta(01.0f, 1.0f, 1.0f);
           Gl.glScalef(0.4f, 0.4f, 0.0f);
           figuraCompuesta(1.0f, 1.0f, 0.0f);
        }

    /* une las figuras triangulo y cuadrado para la base a construir */
        private void figuraCompuesta(float r, float g, float b)
        {
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            cuadrado();
            Gl.glRotated(45, 0, 0, 1);
            cuadrado();
            Gl.glRotated(-45, 0, 0, 1);

            Gl.glColor3f(r, g, b);
            for (int i = 0; i < 360; i += 45) {
                Gl.glRotated(i, 0, 0, 1);
                triangulo();
            }
        }

        private void cuadrado()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2f(0.6f, 0.6f);
            Gl.glVertex2f(-0.6f, 0.6f);
            Gl.glVertex2f(-0.6f, -0.6f);
            Gl.glVertex2f(0.6f, -0.6f);
            Gl.glEnd();
        }

        private void triangulo()
        {
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glVertex2f(0.6f, -0.25f);
            Gl.glVertex2f(0.0f, 0.35f);
            Gl.glVertex2f(-0.6f, -0.25f);
            Gl.glVertex2f(0.6f, -0.25f);
            Gl.glEnd();
        }
    }
}
