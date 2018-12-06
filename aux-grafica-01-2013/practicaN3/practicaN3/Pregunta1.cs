using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**********************/
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta1
    {
        public void dibujar()
        {
            Gl.glScalef(1.2f, 1.2f, 0);
            figuraCompuesta();
        }

        private void figuraCompuesta()
        { 
            Gl.glColor3f(0, 0, 0);
            cuadrado();
            Gl.glRotated(45, 0, 0, 1);
            cuadrado();

            Gl.glColor3f(1, 1, 0);
            Gl.glRotated(45, 0, 0, 1);
            triangulo();
            Gl.glRotated(45, 0, 0, 1);
            triangulo();
            Gl.glRotated(45, 0, 0, 1);
            triangulo();
            Gl.glRotated(45, 0, 0, 1);
            triangulo();
            Gl.glRotated(45, 0, 0, 1);
            triangulo();
            Gl.glLoadIdentity();
        }

        private void cuadrado()
        {
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.5f, 0.5f);
                Gl.glVertex2f(-0.5f, 0.5f);
                Gl.glVertex2f(-0.5f, -0.5f);
                Gl.glVertex2f(0.5f, -0.5f);
            Gl.glEnd();
        }

        private void triangulo()
        {
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0, 0.3f);
                Gl.glVertex2f(-0.5f, -0.2f);
                Gl.glVertex2f(0.5f, -0.2f);
            Gl.glEnd();
        }
    }
}
