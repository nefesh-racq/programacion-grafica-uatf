using System;
using System.Windows.Forms;

using Tao.OpenGl;

namespace tareaN2
{
    class Agente
    {
        protected float _posx, _posy;
        protected float _posinix, _posiniy;
        protected float _posfinz, _posfiny;
        protected float _radio;
        Timer tiempo = new Timer();
        public void caminar(float x0, float y0, float x1, float y1)
        {
            float dx, dy, incx, incy, x, y;
            float pasos;

            dx = x1 - x0;
            dy = y1 - y0;
            pasos = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);
            incx = dx / pasos;
            incy = dy / pasos;
            x = x0; y = y0;

            for (float i = 0; i <= pasos; i++) {
                x += incx;
                y += incy;

                Gl.glColor3f(0, 0, 0);
                Gl.glBegin(Gl.GL_POINTS);
                    Gl.glVertex2f(x / 100, y / 100);
                Gl.glEnd();
                figura(10, x, y);
            }
        }

        public void figura(float radio, float cx, float cy)
        {
            float _angulo, _x, _y;

            for (int i = 0; i <= 360; i++) {
                _angulo = i * (float)Math.PI / 180.0f;
                _x = (float)Math.Cos(_angulo) * radio;
                _y = (float)Math.Sin(_angulo) * radio;
                
                Gl.glColor3f(0, 0, 0);
                Gl.glBegin(Gl.GL_POINTS);
                    Gl.glVertex2f((_x + cx) / 100, (_y + cy) / 100);
                Gl.glEnd();
            }
        }
    }
}
