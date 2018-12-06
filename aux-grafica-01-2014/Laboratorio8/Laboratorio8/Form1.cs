using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            //elipseEcuacion(0.5f, 0.3f);
            //elipseEcuacion(0.3f, 0.5f);

            //circunferenciaTrigonometrica(0.3f,0.5f,0.5f);

            grafico1(0.7f, 0, 0);
        }

        private void circunferenciaTrigonometrica(float radio,float cx,float cy)
        {
            Gl.glBegin(Gl.GL_LINE_LOOP);
            for (float grados = 0; grados < 360; grados += 10.0f)
            {
                float rad = grados * 2 * (float)Math.PI / 360;
                float x = radio*(float)Math.Cos(rad);
                float y = radio*(float)Math.Sin(rad);
                Gl.glVertex2f(x+cx, y+cy);
            }
            Gl.glEnd();
        }

        private void grafico1(float radio,float cx,float cy)
        {
            for (float grados = 0; grados < 360; grados += 10.0f)
            {
                float rad = grados * 2 * (float)Math.PI / 360;
                float x = radio * (float)Math.Cos(rad);
                float y = radio * (float)Math.Sin(rad);
                circunferenciaTrigonometrica(0.01f*(grados/10), x+cx, y+cy);
            }
        }

        private void elipseEcuacion(float a, float b)
        {
            float x, y;
            if (a > b)
            {
                x = 0;
                y = b;
                while (x < a)
                {
                    puntosElipse(x, y);
                    y = b * (float)Math.Sqrt(1 -
                        Math.Pow(x, 2) / Math.Pow(a, 2));
                    x += 0.001f;
                }
            }
            else
            {
                x = a;
                y = 0;
                while (y < b)
                {
                    puntosElipse(x, y);
                    x = a * (float)Math.Sqrt(1 -
                        Math.Pow(y, 2) / Math.Pow(b, 2));
                    y += 0.001f;
                }
            }
        }
        private void puntosElipse(float x,float y)
        {
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(x, y);
            Gl.glVertex2f(-x, y);
            Gl.glVertex2f(-x, -y);
            Gl.glVertex2f(x, -y);
            Gl.glEnd();
        }

       
    }
}