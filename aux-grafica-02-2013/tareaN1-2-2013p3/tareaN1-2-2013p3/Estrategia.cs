using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*****************/
using Tao.OpenGl;

namespace tareaN1_2_2013p3
{
    class Estrategia
    {
        float escala = 100.0f;
        public Estrategia() { }

        public void rectaDDA(int x0, int y0, int x1, int y1) {
            int pasos, i, dx, dy;
            float incX, incY, x, y;

            dx = x1 - x0;
            dy = y1 - y0;

            pasos = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            incX = (float)dx / pasos;
            incY = (float)dy / pasos;
            x = x0;
            y = y0;
            setPixel((int)x, (int)y);

            for (i = 0; i < pasos; i++) {
                x += incX;
                y += incY;
                setPixel((int)x, (int)y);
            }
        }

        private void setPixel(int x, int y) {
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(x / escala, y / escala);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
