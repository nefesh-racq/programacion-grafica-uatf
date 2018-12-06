using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;

namespace Laboratorio4
{
    class Linea
    {
        public Punto p0, p1;
        public ColorOpenGL c;
        public Linea(Punto punto0,Punto punto1,ColorOpenGL color) 
        {
            p0 = punto0;
            p1 = punto1;
            c = color;
        }
        public Linea(Punto punto0, Punto punto1)
        {
            p0 = punto0;
            p1 = punto1;
            c = new ColorOpenGL(0.0f, 0.0f, 0.0f);
        }
        public void setLineColorPoint() 
        {
            Gl.glBegin(Gl.GL_LINES);
            Gl.glColor3f(p0.c.r, p0.c.g, p0.c.b);
            Gl.glVertex2f(p0.x, p0.y);
            Gl.glColor3f(p1.c.r, p1.c.g, p1.c.b);
            Gl.glVertex2f(p1.x, p1.y);
            Gl.glEnd();
        }
        public void setLine()
        {
            Gl.glColor3f(c.r, c.g, c.b);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(p0.x, p0.y);
            Gl.glVertex2f(p1.x, p1.y);
            Gl.glEnd();
        }
    }
}
