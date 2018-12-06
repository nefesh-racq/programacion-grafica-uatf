using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio6
{
    public partial class Form1 : Form
    {
        private float x, y, inc;
        private int estado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            x = -1.0f;
            inc = 0.1f;
            estado = 0;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glPointSize(4.0f);

            Gl.glBegin(Gl.GL_POINTS);
            switch(estado%2)
            {
                case 0: Gl.glVertex2f(0.0f, y); break;
                case 1: Gl.glVertex2f(y, y); break;
            }
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((x > 1.0f) || (x < -1.0f))
            {
                inc = -inc;
                estado++;
            }

            x += inc;
            y = (float)Math.Sin(x);
            simpleOpenGlControl1.Refresh();
        }
    }
}