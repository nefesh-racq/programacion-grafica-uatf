using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Tarea3_preg3
{
    public partial class Form1 : Form
    {
        private int angulo = 20;

        public Form1()
        {
            InitializeComponent();


            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 0, 1, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glRotatef(angulo, 0, 0, 1);
            Figura();
        }

        private void Figura()
        {
            Gl.glTranslatef(0.6f, 0.2f, 0);
            Gl.glColor3f(1f, 0f, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex2f(0.2f, 0.2f);
                Gl.glVertex2f(-0.2f, 0.2f);
                Gl.glVertex2f(-0.2f, -0.2f);
                Gl.glVertex2f(0.2f, -0.2f);
            Gl.glEnd();

            Gl.glTranslatef(-1.2f, 0f, 0);
            Gl.glColor3f(0f, 0f, 1);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex2f(0.2f, 0.2f);
                Gl.glVertex2f(-0.2f, 0.2f);
                Gl.glVertex2f(-0.2f, -0.2f);
                Gl.glVertex2f(0.2f, -0.2f);
            Gl.glEnd();

            Gl.glTranslatef(0.6f, -0.2f, 0);
            Gl.glColor3f(0f, 1f, 1);
            Gl.glLineWidth(4);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(-0.8f, 0);
                Gl.glVertex2f(0.8f, 0);
            Gl.glEnd();

        }

        private void simpleOpenGlControl1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: angulo = 20;break;
                case Keys.Down: angulo = -20; break;
            }

            simpleOpenGlControl1.Refresh();
        }

    }
}

