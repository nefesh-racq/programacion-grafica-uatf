using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace practicaN1
{
    class Punto {
        float x, y;
        Random rd = new Random();
        public void punto() {
            x = rd.Next(-400, 400);
            y = rd.Next(-400, 400);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glPointSize(10);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2d(x, y);

            Gl.glVertex2d(0.5f, 0.0f);
            Gl.glVertex2d(0.8f, 0.5f);
            Gl.glVertex2d(-0.6f, 0.6f);
            
            Gl.glEnd();
        }

        public void dibujar(float x, float y) {
            Gl.glPointSize(10);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glColor3f(0.0f, 0.0f, 0.0f);
            Gl.glVertex2d(x, y);
            Gl.glEnd();
        }

        public bool comido(float x, float y) {
            if (x == this.x && y == this.y)
                return true;
            return false;
        }
    }
}
