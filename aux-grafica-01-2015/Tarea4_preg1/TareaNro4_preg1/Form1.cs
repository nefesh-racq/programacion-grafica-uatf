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
using Tao.FreeGlut;

namespace TareaNro4_preg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.5f, 0, 0.5f, 1);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(50, 1, 0, 100);

            Glut.glutInit();
        }

        private int angulo = 0;

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            //Glu.gluLookAt(0, -2, 20, 0, 0, 0, 0, 1, 0);
            Glu.gluLookAt(30, 13, 30, 0, 0, 0, 0, 1, 0);

            //Gl.glPushMatrix();
            //    Gl.glRotatef(90, 1, 0, 0);
            //    Cuadrado();
            //Gl.glPopMatrix();

            Gl.glPushMatrix();
                //Gl.glRotatef(angulo, 0, 1, 0);
                //EjeDeCoordenadas();
                Gl.glRotatef(190, 0, 1, 0);
                Paisaje();
            Gl.glPopMatrix();
        }


        private void EjeDeCoordenadas()
        {
            int tamanio = 20;

            Gl.glPushMatrix();
            Gl.glLineWidth(10);
            Gl.glColor3f(1, 1, 0);
            Gl.glBegin(Gl.GL_LINES);
                // X
                Gl.glColor3f(0, 1, 0);
                Gl.glVertex3f(-tamanio, 0, 0);
                Gl.glVertex3f(tamanio, 0, 0);

                // Y
                //Gl.glColor3f(0, 1, 0);
                //Gl.glVertex3f(0, -tamanio, 0);
                //Gl.glVertex3f(0, tamanio, 0);

                // Z
                Gl.glColor3f(0, 1, 0);
                Gl.glVertex3f(0, 0, -tamanio);
                Gl.glVertex3f(0, 0, tamanio);
            Gl.glEnd();
            Gl.glPopMatrix();
        }

        private void Paisaje()
        {
            Cuadrado();

            Gl.glPushMatrix();
            Gl.glTranslatef(10, 0, 10);
            Figura();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-10, 0, 10);
            Figura();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-10, 0, -10);
            Figura();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(10, 0, -10);
            Figura();
            Gl.glPopMatrix();
        }

        private void Figura()
        {
            Gl.glPushMatrix();
            Gl.glRotatef(-90, 1, 0, 0);

            Gl.glColor3f(0.55f, 0.2f, 0.22f);
            Gl.glTranslatef(0, 0, -2);
            Glut.glutSolidCylinder(0.8f, 8, 35, 35);

            Gl.glColor3f(0, 0.5f, 0);
            Gl.glTranslatef(0, 0, 2);
            Glut.glutSolidCone(5f, 5, 35, 35);

            Gl.glColor3f(0, 0.7f, 0);
            Gl.glTranslatef(0, 0, 2);
            Glut.glutSolidCone(4f, 5, 35, 35);

            Gl.glColor3f(0, 0.9f, 0);
            Gl.glTranslatef(0, 0, 2);
            Glut.glutSolidCone(3f, 4, 35, 35);
            Gl.glPopMatrix();
        }

        private void Cuadrado()
        {
            int tamanio = 20;
            Gl.glColor3f(0.5f, 0.5f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex3f(tamanio, -2, -tamanio);
                Gl.glVertex3f(-tamanio, -2, -tamanio);
                Gl.glVertex3f(-tamanio, -2, tamanio);
                Gl.glVertex3f(tamanio, -2, tamanio);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (angulo > 360)
                angulo = 0;

            angulo++;

            simpleOpenGlControl1.Refresh();
        }

    }
}
