using System;
using System.Collections.Generic;
using System.Text;
using Tao.OpenGl;
using System.Drawing;

namespace Laboratorio2
{
    class Punto
    {
        public float px,py,pg;
        public Color pc;
        public Punto(float x,float y,float grosor,Color color)
        {
            px = x;
            py = y;
            pg = grosor;
            pc = color;
        }

        public void set()
        {
            Gl.glPointSize(pg);
            Gl.glColor3f((float)pc.R / 255, (float)pc.G / 255, (float)pc.B / 255);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(px,py);    
            Gl.glEnd();
        }
    }
}
