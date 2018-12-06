using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;

namespace Tarea2_preg2
{
    public partial class Form1 : Form
    {
        private int opcion = 1;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.5f, 0.2f, 0.5f, 0.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            switch (opcion)
            {
                case 1: figura1(); break;
                case 2: figura2(); break;
                case 3: figura3(); break;
            }
        }

        private void figura1()
        {
            Gl.glColor3f(0, 0, 1);
            elipse(0.8f, 0.4f, 0, 0);
            //Gl.glColor3f(0, 0.5f, 0);
            elipse(0.2f, 0.1f, -0.75f, 0.5f);
            elipse(0.2f, 0.1f, 0.75f, 0.5f);
            elipse(0.2f, 0.1f, -0.25f, 0.75f);
            elipse(0.2f, 0.1f, 0.25f, 0.75f);
        }

        private void figura2()
        {
            Random rand = new Random();

            for (int i = 0; i < 20; i++)
            {
                Gl.glColor3f(rand.Next(1, 10)/10.0f,
                    rand.Next(1, 10)/10.0f,
                    rand.Next(1, 10)/10.0f
                    );
                float radio = rand.Next(1, 10)/100.0f;
                elipse2(0.08f,
                        0.18f,
                        rand.Next(-10, 10)/10.0f,
                        rand.Next(-10, 10)/10.0f
                        );
            }
        }

        private void figura3()
        {
            Gl.glColor3f(1, 1, 1);
            //float radioA = 0.8f, radioB = 0.4;

            //for (int i = 0; i < 1000; i++)
            {
                elipse3(0.8f, 0.4f, 0, -0.5f);
            }
        }

        private void elipse(float pr0, float pr1, float pcx, float pcy)
        {
            float x, y;
            float angle = 0;
            float r0 = pr0, r1 = pr1;

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(pcx, pcy);
            for (int i = 0; i <= 360; i++)
            {
                angle = i*(float) Math.PI/180.0f;
                x = (float) Math.Sin(angle) * r0;
                y = (float) Math.Cos(angle)*r1;
                Gl.glVertex2f(x+pcx, y+pcy);
            }
            Gl.glEnd();
        }

        private void elipse2(float pr0, float pr1, float pcx, float pcy)
        {
            float x, y;
            float angle = 0;
            float r0 = pr0, r1 = pr1;

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(pcx, pcy);
            for (int i = 0; i <= 360; i++)
            {
                angle = i * (float)Math.PI / 180.0f;
                x = (float)Math.Sin(angle) * r0;
                y = (float)Math.Cos(angle) * r1;
                Gl.glVertex2f(x + pcx, y + pcy);
            }
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(pcx, pcy);
            for (int i = 0; i <= 360; i++)
            {
                angle = i * (float)Math.PI / 180.0f;
                x = (float)Math.Sin(angle) * r1;
                y = (float)Math.Cos(angle) * r0;
                Gl.glVertex2f(x + pcx, y + pcy);
            }
            Gl.glEnd();
        }

        private void elipse3(float pr0, float pr1, float pcx, float pcy)
        {
            float x, y;
            float angle = 0;
            float r0 = pr0, r1 = pr1;
            float b = 0.03f;
            float inc = 0.0f;

            Gl.glBegin(Gl.GL_POINTS);
            //Gl.glVertex2f(pcx, pcy);
            for (int i = 90; i <= (360 * 4) - 90; i++)
            {
                angle = i * (float)Math.PI / 180.0f;
                x = (float) Math.Sin(angle)*r0;// * (b*angle);
                y = (float) Math.Cos(angle)*r1;//* (b * angle);
                Gl.glVertex2f(x + pcx, y + (pcy + inc));

                inc += 0.0006f;
            }
            Gl.glEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opcion = 1;
            simpleOpenGlControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opcion = 2;
            simpleOpenGlControl1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opcion = 3;
            simpleOpenGlControl1.Refresh();
        }

    }
}
