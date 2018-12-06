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

namespace tarea4_preg2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.2f, 0, 0.5f, 1);
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

            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_CULL_FACE);
            //Glu.gluLookAt(0, -2, 20, 0, 0, 0, 0, 1, 0);
            Glu.gluLookAt(30, 0, 30, 0, 0, 0, 0, 1, 0);
            
            //Gl.glPushMatrix();
                  
            //    Figura();
            //Gl.glPopMatrix();

            //Gl.glColor3f(0f, 0, 0.5f);
            //Gl.glPushMatrix();
            //    Gl.glTranslatef(0, -5, 0);
            //    Gl.glRotatef(90, 1, 0, 0);
            //    Glut.glutSolidCone(4f, 5, 35, 35);
            //Gl.glPopMatrix();

            //Gl.glPushMatrix();
            //    Gl.glTranslatef(-5, 0, 0);
            //    Gl.glRotatef(-90, 0, 1, 0);
            //    Glut.glutSolidCone(4f, 5, 35, 35);
            //Gl.glPopMatrix();

            //Gl.glPushMatrix();
            //Gl.glTranslatef(5, 0, 0);
            //Gl.glRotatef(90, 0, 1, 0);
            //Glut.glutSolidCone(4f, 5, 35, 35);
            //Gl.glPopMatrix();

            //Gl.glPushMatrix();
            //Gl.glTranslatef(0, 0, 5);
            //Gl.glRotatef(0, 0, 1, 0);
            //Glut.glutSolidCone(4f, 5, 35, 35);
            //Gl.glPopMatrix();

            //Gl.glPushMatrix();
            //Gl.glTranslatef(0, 0, -5);
            //Gl.glRotatef(180, 0, 1, 0);
            //Glut.glutSolidCone(4f, 5, 35, 35);
            //Gl.glPopMatrix();

            Gl.glColor3f(0f, 0.5f, 0f);
            Glut.glutSolidCube(10);

            Gl.glPushMatrix();
                Gl.glPushMatrix();
                    Gl.glColor3f(0.5f, 0f, 0f);
                    Gl.glTranslatef(0, 10, 0);
                    Gl.glRotatef(90, 1, 0, 0);
                    Glut.glutSolidCylinder(0.8f, 5, 35, 35);
                    Gl.glPopMatrix();


                    Gl.glPushMatrix();
                    Gl.glColor3f(0.5f, 0.5f, 0f);
                    //Gl.glRotatef(90, 1, 0, 0);
                    Gl.glRotatef(angulo, 0, 1, 0);
                    Gl.glTranslatef(0, 10, -4);
                    Glut.glutSolidCylinder(0.8f, 8, 35, 35);
                Gl.glPopMatrix();
            Gl.glPopMatrix();


            Gl.glPushMatrix();
                Gl.glRotatef(90, 0, 0, 1);
                Gl.glPushMatrix();
                    Gl.glColor3f(0.5f, 0f, 0f);
                    Gl.glTranslatef(0, 10, 0);
                    Gl.glRotatef(90, 1, 0, 0);
                    Glut.glutSolidCylinder(0.8f, 5, 35, 35);
                    Gl.glPopMatrix();


                    Gl.glPushMatrix();
                    Gl.glColor3f(0.5f, 0.5f, 0f);
                    //Gl.glRotatef(90, 1, 0, 0);
                    Gl.glRotatef(angulo, 0, 1, 0);
                    Gl.glTranslatef(0, 10, -4);
                    Glut.glutSolidCylinder(0.8f, 8, 35, 35);
                Gl.glPopMatrix();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glRotatef(-90, 0, 0, 1);
            Gl.glPushMatrix();
            Gl.glColor3f(0.5f, 0f, 0f);
            Gl.glTranslatef(0, 10, 0);
            Gl.glRotatef(90, 1, 0, 0);
            Glut.glutSolidCylinder(0.8f, 5, 35, 35);
            Gl.glPopMatrix();


            Gl.glPushMatrix();
            Gl.glColor3f(0.5f, 0.5f, 0f);
            //Gl.glRotatef(90, 1, 0, 0);
            Gl.glRotatef(angulo, 0, 1, 0);
            Gl.glTranslatef(0, 10, -4);
            Glut.glutSolidCylinder(0.8f, 8, 35, 35);
            Gl.glPopMatrix();
            Gl.glPopMatrix();


            //Gl.glPushMatrix();
            //Gl.glRotatef(90, 1, 0, 0);
            //Gl.glPushMatrix();
            //Gl.glColor3f(0.5f, 0f, 0f);
            //Gl.glTranslatef(0, 10, 0);
            //Gl.glRotatef(90, 1, 0, 0);
            //Glut.glutSolidCylinder(0.8f, 5, 35, 35);
            //Gl.glPopMatrix();


            //Gl.glPushMatrix();
            //Gl.glColor3f(0.5f, 0.5f, 0f);
            ////Gl.glRotatef(90, 1, 0, 0);
            //Gl.glRotatef(angulo, 0, 1, 0);
            //Gl.glTranslatef(0, 10, -4);
            //Glut.glutSolidCylinder(0.8f, 8, 35, 35);
            //Gl.glPopMatrix();
            //Gl.glPopMatrix();

            //Gl.glPushMatrix();
            //Gl.glRotatef(-90, 1, 0, 0);
            //Gl.glPushMatrix();
            //Gl.glColor3f(0.5f, 0f, 0f);
            //Gl.glTranslatef(0, 10, 0);
            //Gl.glRotatef(90, 1, 0, 0);
            //Glut.glutSolidCylinder(0.8f, 5, 35, 35);
            //Gl.glPopMatrix();


            //Gl.glPushMatrix();
            //Gl.glColor3f(0.5f, 0.5f, 0f);
            ////Gl.glRotatef(90, 1, 0, 0);
            //Gl.glRotatef(angulo, 0, 1, 0);
            //Gl.glTranslatef(0, 10, -4);
            //Glut.glutSolidCylinder(0.8f, 8, 35, 35);
            //Gl.glPopMatrix();
            //Gl.glPopMatrix();
        }


        private void Figura()
        {
            int tamanio = 20;
            Gl.glColor3f(0.5f, 0.5f, 0.5f);
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex3f(2, 0.5f, 0);
                Gl.glVertex3f(-2, 0.5f, 0);
                Gl.glVertex3f(-2, -0.5f, 0);
                Gl.glVertex3f(2, -0.5f, 0);
            Gl.glEnd();

        }

        private void Cubo()
        {
            //int tamanio = 8;
            //Gl.glColor3f(0.5f, 0.5f, 0.5f);
            //Gl.glBegin(Gl.GL_POLYGON);
            //    Gl.glVertex3f(tamanio, tamanio, tamanio / 2.0f);
            //    Gl.glVertex3f(-tamanio, tamanio, tamanio / 2.0f);
            //    Gl.glVertex3f(-tamanio, -tamanio, tamanio / 2.0f);
            //    Gl.glVertex3f(tamanio, -tamanio, tamanio / 2.0f);
            //Gl.glEnd();


            //Gl.glBegin(Gl.GL_POLYGON);
            //    Gl.glVertex3f(tamanio, tamanio, tamanio / 2.0f);
            //    Gl.glVertex3f(-tamanio, tamanio, tamanio / 2.0f);
            //    Gl.glVertex3f(-tamanio, -tamanio, tamanio / 2.0f);
            //    Gl.glVertex3f(tamanio, -tamanio, tamanio / 2.0f);
            //Gl.glEnd();
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
