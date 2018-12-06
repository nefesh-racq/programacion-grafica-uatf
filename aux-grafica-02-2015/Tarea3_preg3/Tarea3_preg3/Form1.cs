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
        private float angle = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.3f, 0.3f, 0.3f, 1.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();
            //Gl.glRotatef(angle, 0.0f, 0.0f, 1.0f);

            Gl.glTranslatef(-.4f, -.40f, 0.0f);
            Gl.glScalef(0.8f, 0.8f, 0.0f);
            Gl.glPushMatrix();
            figurafinal();
            Gl.glTranslatef(1.0f, 0.0f, 0.0f);
            figurafinal();
            
            Gl.glTranslatef(0.0f, 1.0f, 0.0f);
            figurafinal();

            Gl.glTranslatef(-1.0f, 0.0f, 0.0f);
            figurafinal();

            Gl.glTranslatef(0.0f, -1.0f, 0.0f);
            figurafinal();
            Gl.glPopMatrix();
        }

        private void figurafinal()
        {
            Gl.glPushMatrix();

            figuraCompuesta();
            //Gl.glRotatef(45, 0.0f, 0.0f, 1.0f);
            Gl.glScalef(.8f, .8f, 0.0f);
            figuraCompuesta();
            Gl.glScalef(.8f, .8f, 0.0f);
            figuraCompuesta();
            Gl.glScalef(.8f, .8f, 0.0f);
            figuraCompuesta();
            Gl.glPopMatrix();
        }

        private void figuraCompuesta()
        {
            Gl.glPushMatrix();
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            quads();
            Gl.glRotatef(45, 0.0f, 0.0f, 1.0f);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            quads();
            Gl.glPopMatrix();
        }

        private void quads()
        {
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glVertex2f(0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, 0.5f);
            Gl.glVertex2f(-0.5f, -0.5f);
            Gl.glVertex2f(0.5f, -0.5f);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (angle++ > 360)
                angle = 0;
            simpleOpenGlControl1.Refresh();
        }

    }
}
