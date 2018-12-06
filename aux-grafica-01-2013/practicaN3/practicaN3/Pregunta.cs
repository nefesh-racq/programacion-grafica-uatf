using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/******************************/
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta
    {
        private int escala;

        public Pregunta(int esc)
        {
            escala = esc;
        }

        public void dibujar()
        {
            int i = 0, j = 0;
            float tx = -0.9f, 
                  ty = 0.9f,
                  inc = 0.2f;

            Gl.glColor3f(1, 0, 0);
            while (++i <= 10) {

                while (++j <= 10) {
                    
                    Gl.glTranslatef(tx, ty, 0);
                    cuadrado();
                    tx += inc;
                    Gl.glLoadIdentity();
                }

                tx = -0.9f;
                ty -= inc;
                j = 0;
            }
        }

        private void cuadrado()
        {
            Gl.glScalef(0.2f, 0.2f, 0);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(0.5f, 0.5f);
                Gl.glVertex2f(-0.5f, 0.5f);
                Gl.glVertex2f(-0.5f, -0.5f);
                Gl.glVertex2f(0.5f, -0.5f);
            Gl.glEnd();
        }
    }
}
