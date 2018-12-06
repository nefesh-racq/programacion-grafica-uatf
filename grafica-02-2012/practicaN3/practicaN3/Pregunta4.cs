using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta4
    {
        public void dibujar()
        {
            figuraCentral();
            fiigurasEntornoSuperior();
            figurasEntornoInferior();
        }

    /**** dibuja las figuras de la parte de abajo *****/
        private void figurasEntornoInferior()
        {
            Gl.glTranslated(-0.68f, -0.1f, 0);
            Gl.glScalef(0.15f, 0.15f, 0);
            Gl.glRotated(-5, 0, 0, 1);
            estrella();

            Gl.glTranslated(-0.65f, -0.5f, 0);
            Gl.glScalef(0.18f, 0.18f, 0);
            Gl.glRotated(4, 0, 0, 1);
            estrella();

            Gl.glTranslated(-0.45f, -0.8f, 0);
            Gl.glScalef(0.25f, 0.25f, 0);
            Gl.glRotated(5, 0, 0, 1);
            estrella();

            Gl.glTranslated(0.0f, -0.84f, 0);
            Gl.glScalef(0.3f, 0.3f, 0);
            estrella();

            Gl.glTranslated(0.5f, -0.78f, 0);
            Gl.glScalef(0.35f, 0.35f, 0);
            Gl.glRotated(-10, 0, 0, 1);
            estrella();

            Gl.glTranslated(0.7f, -0.35f, 0);
            Gl.glScalef(0.28f, 0.28f, 0);
            Gl.glRotated(-10, 0, 0, 1);
            estrella();

            Gl.glTranslated(0.77f, -0.005f, 0);
            Gl.glScalef(0.21f, 0.21f, 0);
            Gl.glRotated(-5, 0, 0, 1);
            estrella();
        }

    /***** dibuja el entorno de estrellas ******/
        private void fiigurasEntornoSuperior()
        {
            Gl.glTranslated(-0.65f, 0.4f, 0);
            Gl.glScalef(0.1f, 0.1f, 0);
            Gl.glRotated(-20, 0, 0, 1);
            estrella();

            Gl.glTranslated(-0.55f, 0.6f, 0);
            Gl.glScalef(0.12f, 0.12f, 0);
            Gl.glRotated(-13, 0, 0, 1);
            estrella();

            Gl.glTranslated(-0.35f, 0.76f, 0);
            Gl.glScalef(0.15f, 0.15f, 0);
            Gl.glRotated(-10, 0, 0, 1);
            estrella();

            Gl.glTranslated(-0.1f, 0.85f, 0);
            Gl.glScalef(0.18f, 0.18f, 0);
            Gl.glRotated(-10, 0, 0, 1);
            estrella();

            Gl.glTranslated(0.2f, 0.82f, 0);
            Gl.glScalef(0.21f, 0.21f, 0);
            Gl.glRotated(-10, 0, 0, 1);
            estrella();

            Gl.glTranslated(0.45f, 0.65f, 0);
            Gl.glScalef(0.2f, 0.2f, 0);
            Gl.glRotated(-10, 0, 0, 1);
            estrella();

            Gl.glTranslated(0.7f, 0.4f, 0);
            Gl.glScalef(0.21f, 0.21f, 0);
            Gl.glRotated(-5, 0, 0, 1);
            estrella();
        }

    /***** dibuja la estrella principal mas sus estrellas internas*********/
        private void figuraCentral()
        {
            estrella();
            Gl.glScalef(0.5f, 0.5f, 0);
            estrella();
            Gl.glScalef(0.15f, 0.15f, 0);
            estrella();
        }

        private void estrella()
        {
            float inc, x, y, rad;

            Gl.glRotated(55, 0, 0, 1);
            inc = 360 / 10;
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glColor3f(0.0f, 0.0f, 0.0f);

            for (float grados = 0; grados <= 360; grados += inc)
            {
                rad = grados * (float)Math.PI / 180;
                x = (float)Math.Cos(rad);
                y = (float)Math.Sin(rad);

                if (grados % 72 == 0)
                    Gl.glVertex2d(x * 0.35f, y * 0.35f);
                else
                    Gl.glVertex2d(x * 0.7f, y * 0.7f);
            }

            Gl.glEnd();
            Gl.glLoadIdentity();
        }
    }
}
