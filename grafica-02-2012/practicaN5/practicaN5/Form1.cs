using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace practicaN5
{
    public partial class Form1 : Form
    {
        private int tipo = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);

            /* indicar el tipo de proyeccion */
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, 1, 1, 10);
            //Gl.glOrtho(-3, 3, -3, 3, 1, 10);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(3, 3, 3, 0, 0, 0, 0, 1, 0);
            Gl.glEnable(Gl.GL_CULL_FACE);
            Gl.glRotated(ladoX, 1, 0, 0);
            Gl.glRotated(ladoY, 0, 1, 0);
            Gl.glRotated(ladoZ, 0, 0, 1);

            switch (tipo) {
                case 1: piramideCuadrada(); break;
                case 2: piramideTriangular(); break;
            }
        }


/****************************************************************************
*      fimvopm ára dinujar a iramide cuadrada                               *
****************************************************************************/
        private void piramideCuadrada() 
        {
            // dibuja a base de la iramide
            Gl.glBegin(Gl.GL_QUADS);
            Gl.glColor3f(1.0f, 0.0f, 1.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -1.0f);
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);
            Gl.glEnd();


            // dibuja el lado derecho de la piramnide
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glEnd();

            // dibuja el lado frontal de la piramnide
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, 1.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);            
            Gl.glEnd();

            // dibuja el lado izquierda de la piramide
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, 1.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -1.0f);
            Gl.glEnd();

            // dinbuja la cara de atras de la piramide
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(0.0f, 1.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -1.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, -1.0f);
            Gl.glEnd();
        }
 /****************************************************************************
 *      fimvopm ára dinujar a iramide triangular                             *
 ****************************************************************************/
        private void piramideTriangular()
        {
            // dibuja la base de la piramide
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(0.0f, 1.0f, 1.0f);
            Gl.glVertex3f(0.0f, -1.0f, 1.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -0.6f);
            Gl.glVertex3f(1.0f, -1.0f, -0.6f);
            Gl.glEnd();

            // dibuja el lado derecho 
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(0.0f, 0.0f, 1.0f);
            Gl.glVertex3f(0.0f, -1.0f, 1.0f);
            Gl.glVertex3f(1.0f, -1.0f, -0.6f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glEnd();

            // dibuja el lado izquierdo
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(1.0f, 0.0f, 1.0f);
            Gl.glVertex3f(0.0f, -1.0f, 1.0f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -0.6f);
            Gl.glEnd();

            // dibuja el lado de atras
            Gl.glBegin(Gl.GL_TRIANGLES);
            Gl.glColor3f(1.0f, 1.0f, 0.0f);
            Gl.glVertex3f(-1.0f, -1.0f, -0.6f);
            Gl.glVertex3f(0.0f, 1.0f, 0.0f);
            Gl.glVertex3f(1.0f, -1.0f, -0.6f);
            Gl.glEnd();
        }


/********************************************************************************
*       funciones para rotar las piramides                                      *
********************************************************************************/
        private float ladoX = 0, ladoY = 0, ladoZ = 0;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ladoX = (float)trackBar1.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ladoY = (float)trackBar2.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            ladoZ = (float)trackBar3.Value;
            simpleOpenGlControl1.Refresh();
        }


/********************************************************************************
*       funciones para elegir las piramides                                     *
********************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            tipo = 1;
            simpleOpenGlControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tipo = 2;
            simpleOpenGlControl1.Refresh();
        }
    }
}
