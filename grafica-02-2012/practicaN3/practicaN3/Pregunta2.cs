using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace practicaN3
{
    class Pregunta2
    {
    /***** dibuja la figura completa ******/
        public void dibujar()
        {
            figuraConpuesta(1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);
            Gl.glRotated(60, 0, 0, 1);
            Gl.glScalef(0.58f, 0.58f, 0);
            figuraConpuesta(1.0f, 1.0f, 1.0f, 1.0f, 1.0f, 0.0f);
        }

    /*****  forma la figura base con triangulo y hexagono y pasa los colores *****/
        private void figuraConpuesta(float rt, float gt, float bt, float rh, float gh, float bh)
        {
            Gl.glColor3f(rt, gt, bt);
            triangulo();
            Gl.glRotated(180, 0, 0, 1);
            triangulo();
            Gl.glColor3f(rh, gh, bh);
            Gl.glRotated(90, 0, 0, 1);
            hexagono();
        }

        private void triangulo()
        {
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glVertex2f(1.0f, 0.0f);
            Gl.glVertex2f(-0.5f, 0.87f);
            Gl.glVertex2f(-0.5f, -0.87f);
            Gl.glEnd();
        }

        private void hexagono()
        {
            float inc, x, y, rad;

            inc = 360 / 6;
            Gl.glBegin(Gl.GL_POLYGON);

            for (float grados = 0; grados <= 360; grados += inc) {
                rad = grados * (float)Math.PI / 180;
                x = (float)Math.Cos(rad);
                y = (float)Math.Sin(rad);
                Gl.glVertex2d(x * 0.58f, y * 0.58f);
            }

            Gl.glEnd();
        }
    }
}
