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

namespace Tarea1_preg3
{
    public partial class Form1 : Form
    {
        private bool punto = true;
        private float px = 0, py = 0;
        private int i = 0;
        private float ang = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.5f, 0.2f, 0.5f, 0.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            drawCircle();

            Gl.glPushMatrix();
                line();
            Gl.glPopMatrix();
        }

        private void drawCircle()
        {
            float x, y;
            float ang;
            int i;
            var random = new Random();

            Gl.glColor3f(0.9f, 0.9f, 0.9f);
            Gl.glPointSize(1);
            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(0, 0);

            for (i = 0; i <= 360; i++)
            {
                ang = i * (float)Math.PI / 180.0f;
                x = (float)Math.Sin(ang);
                y = (float)Math.Cos(ang);

                Gl.glVertex2f(x, y);
            }

            Gl.glEnd();

            // eje de coordenadas
            Gl.glColor3f(0.5f, 0.2f, 0.5f);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(-1, 0);
                Gl.glVertex2f(1, 0);
               
                Gl.glVertex2f(0, -1);
                Gl.glVertex2f(0, 1);
            Gl.glEnd();


            Gl.glBegin(Gl.GL_POINTS);

            for (i = 0; i <= 360; i++)
            {
                ang = i * (float)Math.PI / 180.0f;
                x = (float)Math.Sin(ang);
                y = (float) Math.Cos(ang);

                Gl.glVertex2f(x * 0.3f, y * 0.3f);

                Gl.glVertex2f(x * 0.7f, y * 0.7f);
            }
            Gl.glEnd();

            if (punto)
                Gl.glColor3f(0, 0, 1);
            else
                Gl.glColor3f(0.9f, 0.9f, 0.9f);

            Gl.glPointSize(8);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(0.5f, 0.5f);
                Gl.glVertex2f(0.5f, 0.3f);
                Gl.glVertex2f(0.3f, 0.3f);
                Gl.glVertex2f(0.3f, 0.1f);
            Gl.glEnd();
        }

        private void line()
        {
            Gl.glColor3f(1, 0, 0);
            //Gl.glPointSize(8);
            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0f, 0f);
                Gl.glVertex2f(px, py);
            Gl.glEnd();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            punto = !punto;
            simpleOpenGlControl1.Refresh();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i++ > 360)
                i = 0;

            ang = i * (float)Math.PI / 180.0f;
            px = (float)Math.Sin(ang);
            py = (float)Math.Cos(ang);

            simpleOpenGlControl1.Refresh();
        }

    }
}
