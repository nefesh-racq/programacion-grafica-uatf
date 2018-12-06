using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio3
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
            Random r = new Random();
            Gl.glBegin(Gl.GL_LINE_STRIP);
            for (int i = 0; i < 200; i++)
            {
                float x = (float)r.Next(-100, 100)/100;
                float y = (float)r.Next(-100, 100)/100;
                
                float rojo = (float)r.Next(0, 100)/100;
                float verde = (float)r.Next(0, 100) / 100;
                float azul = (float)r.Next(0, 100) / 100;
                Gl.glColor3f(rojo,verde,azul);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
        }
    }
}