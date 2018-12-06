using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio1
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
            Gl.glClearColor(0.75f, 0.99f, 0.6f, 0.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            ejeCoordenadas();
            switch (op)
            {
                case 1: sin(); break;
                case 2: cos(); break;
                case 3: sin(); cos(); tan(); break;
                case 4: tan(); break;
            }
        }

        private void tan()
        {
            //grafico de la funcion tan
            Gl.glColor3f(1.0f, 0.0f, 1.0f);
            Gl.glBegin(Gl.GL_POINTS);
            for (float x = -10.0f; x <= 10.0f; x += 0.01f)
            {
                float y = (float)Math.Tan(x);
                Gl.glVertex2f(x * 0.1f, y * 0.1f);
            }
            Gl.glEnd();
        }

        private void ejeCoordenadas()
        {
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glBegin(Gl.GL_POINTS);
            for (float v = -1.0f; v <= 1.0f; v += 0.001f)
            {
                Gl.glVertex2f(v,0.0f);//linea horizontal
                Gl.glVertex2f(0.0f, v);//linea vertical
            }

            for (float v = -1.0f; v <= 1.0f; v += 0.1f)
            {
                for (float u = -0.01f; u <= 0.01f; u += 0.001f)
                {
                    Gl.glVertex2f(v,u);
                    Gl.glVertex2f(u, v);
                }
            }
            Gl.glEnd();
        }

        private void cos()
        {
            //grafico de la funcion cos
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glBegin(Gl.GL_POINTS);
            for (float x = -10.0f; x <= 10.0f; x += 0.01f)
            {
                float y = (float)Math.Cos(x);
                Gl.glVertex2f(x * 0.1f, y * 0.1f);
            }
            Gl.glEnd();
        }

        private void sin()
        {
            //grafico de la funcion sin
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glBegin(Gl.GL_POINTS);
            for (float x = -10.0f; x <= 10.0f; x += 0.01f)
            {
                float y = (float)Math.Sin(x);
                Gl.glVertex2f(x * 0.1f, y * 0.1f);
            }
            Gl.glEnd();
        }

        private int op;

        private void button1_Click(object sender, EventArgs e)
        {
            op = 1;
            simpleOpenGlControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = 2;
            simpleOpenGlControl1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            op = 3;
            simpleOpenGlControl1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = 4;
            simpleOpenGlControl1.Refresh();
        }
    }
}