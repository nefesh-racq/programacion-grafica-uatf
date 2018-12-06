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

namespace Tarea5_preg1
{
    public partial class Form1 : Form
    {
        private float angle = 0;
        private float angleX = 0;
        private float angleY = 0;
        private float angleZ = 0;
        private float angulo0 = 0;
        private float angulo1 = 0;

        private Cubo cubo;
        private int giro = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            //Gl.glClearColor(0.6f, 1.0f, 0.6f, 1.0f);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, 1.0f, 1.0f, 500.0f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Glut.glutInit();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            cubo = new Cubo();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glTranslatef(-0.0f, 0.0f, -15.0f);

            Gl.glRotatef(angleX, 1.0f, 0.0f, 0.0f);
            Gl.glRotatef(angleY, 0.0f, 1.0f, 0.0f);
            Gl.glRotatef(angleZ, 0.0f, 0.0f, 1.0f);

            //cubo.dibujar(); 
            Gl.glPushMatrix();
            Gl.glRotatef(angulo0, 1.0f, 0.0f, 0.0f);
            // abajo izquierda
            Gl.glPushMatrix();
            Gl.glTranslatef(-2, -2, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-2, -2, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-2, -2, 2);
            cubo.cubo();
            Gl.glPopMatrix();


            // izquierda medio
            Gl.glPushMatrix();
            Gl.glTranslatef(-2, 0, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-2, 0, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-2, 0, 2);
            cubo.cubo();
            Gl.glPopMatrix();

            // izquierda arriba
            Gl.glPushMatrix();
            Gl.glTranslatef(-2, 2, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-2, 2, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(-2, 2, 2);
            cubo.cubo();
            Gl.glPopMatrix();
            Gl.glPopMatrix();


            Gl.glPushMatrix();
            Gl.glRotatef(-angulo0, 1.0f, 0.0f, 0.0f);
            // medio abajo
            Gl.glPushMatrix();
            Gl.glTranslatef(0, -2, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0, -2, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0, -2, 2);
            cubo.cubo();
            Gl.glPopMatrix();


            // medio medio
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0, 0, 2);
            cubo.cubo();
            Gl.glPopMatrix();


            // medio arriba
            Gl.glPushMatrix();
            Gl.glTranslatef(0, 2, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0, 2, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(0, 2, 2);
            cubo.cubo();
            Gl.glPopMatrix();
            Gl.glPopMatrix();


            Gl.glPushMatrix();
            Gl.glRotatef(angulo0, 1.0f, 0.0f, 0.0f);
            // deracha abajo
            Gl.glPushMatrix();
            Gl.glTranslatef(2, -2, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(2, -2, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(2, -2, 2);
            cubo.cubo();
            Gl.glPopMatrix();

            // derecha medio
            Gl.glPushMatrix();
            Gl.glTranslatef(2, 0, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(2, 0, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(2, 0, 2);
            cubo.cubo();
            Gl.glPopMatrix();


            // derecha medio
            Gl.glPushMatrix();
            Gl.glTranslatef(2, 2, -2);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(2, 2, 0);
            cubo.cubo();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
            Gl.glTranslatef(2, 2, 2);
            cubo.cubo();
            Gl.glPopMatrix();
            Gl.glPopMatrix();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (++angle > 360)
            //    angle = 0;

            //simpleOpenGlControl1.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            angleX = trackBar1.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            angleY = trackBar2.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            angleZ = trackBar3.Value;
            simpleOpenGlControl1.Refresh();
        }

        bool v = true;
        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            v = true;
            simpleOpenGlControl1.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (v)
            {
                if ((angulo0 += 10)%90 == 0)
                {
                    timer2.Enabled = false;
                }
            }
            else
            {
                if ((angulo1 += 10) % 90 == 0)
                {
                    timer2.Enabled = false;
                }   
            }

            simpleOpenGlControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            v = false;
            simpleOpenGlControl1.Refresh();
        }

    }
}
