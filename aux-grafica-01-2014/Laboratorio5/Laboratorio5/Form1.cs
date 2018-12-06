using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio5
{
    public partial class Form1 : Form
    {
        private List<Punto> lista;
        private int iter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            lista = new List<Punto>();
            iter = 0;
            //calcular los puntos de la recta
           // rectaEcuacion(0.0f, 0.0f, 1.0f, 0.57f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(0.0f, 0.0f);
            Gl.glVertex2f(1.0f, 0.57f);
            Gl.glEnd();

            Gl.glPointSize(3.0f);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            setPixel(lista[iter].x, lista[iter].y);
        }

        private void rectaEcuacion(float x1,float y1,float x2,float y2)
        {
            float dx, dy, b, m, x, y;
            dx = x2 - x1;
            dy = y2 - y1;
            m = dy / dx;
            b = y1 - m * x1;
            y = y1;
            for (x = x1; x <= x2; x += 0.01f)
            {
                //setPixel(x, y);
                lista.Add(new Punto(x,y));
                y = m * x + b;
            }
        }

        private void setPixel(float x, float y)
        {
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(x, y);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (iter < lista.Count - 1)
                iter++;
            else
                iter = 0;
            simpleOpenGlControl1.Refresh();
        }
    }
}