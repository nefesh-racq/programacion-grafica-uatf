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

namespace Tarea5_preg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0, 0, 0, 1);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(60, 1, 0, 100);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Glu.gluLookAt(0, 30, 30, 0, 0, 0, 0, 1, 0);
            
            Gl.glEnable(Gl.GL_CULL_FACE);
            Gl.glRotatef(girarX, 1, 0, 0);
            Gl.glRotatef(girarY, 0, 1, 0);
            Gl.glRotatef(girarZ, 0, 0, 1);
            Torre();
        }


        private void Torre()
        {
            Gl.glColor3f(0, 0, 1);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex3f(5, 0, -2.5f);
                Gl.glVertex3f(5, 0, 2.5f);
                Gl.glVertex3f(2.5f, 0, 5);
                Gl.glVertex3f(-2.5f, 0, 5);
                Gl.glVertex3f(-5, 0, 2.5f);
                Gl.glVertex3f(-5, 0, -2.5f);
                Gl.glVertex3f(-2.5f, 0, -5f);
                Gl.glVertex3f(2.5f, 0, -5);
            Gl.glEnd();

            Gl.glColor3f(0, 0, 1);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex3f(2.5f, 20, -5);
                Gl.glVertex3f(-2.5f, 20, -5f);
                Gl.glVertex3f(-5, 20, -2.5f);
                Gl.glVertex3f(-5, 20, 2.5f);
                Gl.glVertex3f(-2.5f, 20, 5);
                Gl.glVertex3f(2.5f, 20, 5);
                Gl.glVertex3f(5, 20, 2.5f);
                Gl.glVertex3f(5, 20, -2.5f);
            Gl.glEnd();

            Gl.glColor3f(1, 0, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(5, 0, -2.5f);
                Gl.glVertex3f(5, 20, -2.5f);
                Gl.glVertex3f(5, 20, 2.5f);
                Gl.glVertex3f(5, 0, 2.5f);
            Gl.glEnd();


            Gl.glColor3f(0.8f, 0, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(5, 0, 2.5f);
                Gl.glVertex3f(5, 20, 2.5f);
                Gl.glVertex3f(2.5f, 20, 5);
                Gl.glVertex3f(2.5f, 0, 5);
            Gl.glEnd();

            Gl.glColor3f(0.6f, 0, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(2.5f, 0, 5);
                Gl.glVertex3f(2.5f, 20, 5);
                Gl.glVertex3f(-2.5f, 20, 5);
                Gl.glVertex3f(-2.5f, 0, 5);
            Gl.glEnd();

            Gl.glColor3f(0.4f, 0, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(-2.5f, 0, 5);
                Gl.glVertex3f(-2.5f, 20, 5);
                Gl.glVertex3f(-5, 20, 2.5f);
                Gl.glVertex3f(-5, 0, 2.5f);
            Gl.glEnd();

            Gl.glColor3f(0.2f, 0, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(-5, 0, 2.5f);
                Gl.glVertex3f(-5, 20, 2.5f);
                Gl.glVertex3f(-5, 20, -2.5f);
                Gl.glVertex3f(-5, 0, -2.5f);
            Gl.glEnd();

            Gl.glColor3f(0, 1, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(-5, 0, -2.5f);
                Gl.glVertex3f(-5, 20, -2.5f);
                Gl.glVertex3f(-2.5f, 20, -5f);
                Gl.glVertex3f(-2.5f, 0, -5f);
            Gl.glEnd();

            Gl.glColor3f(0, 0.8f, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(-2.5f, 0, -5f);
                Gl.glVertex3f(-2.5f, 20, -5f);
                Gl.glVertex3f(2.5f, 20, -5);
                Gl.glVertex3f(2.5f, 0, -5);
            Gl.glEnd();

            Gl.glColor3f(0, 0.6f, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex3f(2.5f, 0, -5);
                Gl.glVertex3f(2.5f, 20, -5);
                Gl.glVertex3f(5, 20, -2.5f);
                Gl.glVertex3f(5, 0, -2.5f);
            Gl.glEnd();

        }


        private int girarX = 0, girarY = 0, girarZ = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            girarX = trackBar1.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            girarY = trackBar2.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            girarZ = trackBar3.Value;
            simpleOpenGlControl1.Refresh();
        }

    }
}
