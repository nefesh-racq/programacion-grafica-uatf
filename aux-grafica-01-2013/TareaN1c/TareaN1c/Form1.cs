using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/***************************/
using Tao.OpenGl;

namespace TareaN1c
{
    public partial class Form1 : Form
    {
        private int cont;
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 1, 0);
            cont = 0;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3f(0, 0, 0);

            circulo(0, 0, 90);
            numeros(0, 0, 85);
            segundero();
        }

        private void circulo(int cx, int cy, int cr)
        {
            float angulo, x, y;

            for (int i = 0; i <= 360; i++) {
                angulo = i * (float)Math.PI / 180.0f;
                x = ((float)Math.Cos(angulo) * cr) + cx;
                y = ((float)Math.Sin(angulo) * cr) + cy;
                setPixel((int)x, (int)y, 100);
            }
        }

        private void numeros(int cx, int cy, int cr)
        {
            float angulo, x, y;

            Gl.glBegin(Gl.GL_LINES);

            for (int i = 0; i <= 360; i += 6) {
                angulo = i * (float)Math.PI / 180.0f;
                x = (float)Math.Cos(angulo);
                y = (float)Math.Sin(angulo);

                Gl.glVertex2f(((x * (cr - 7)) + cx) / 100.0f, ((y * (cr - 7)) + cy) / 100.0f);
                Gl.glVertex2f(((x * cr) + cx) / 100.0f, ((y * cr) + cy) / 100.0f);
            }

            Gl.glEnd();
        }

        private void setPixel(int cx, int cy, int div)
        {
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(cx / (float)div, cy / (float)div);
            Gl.glEnd();
        }

        private void segundero()
        {
            float x, y, angulo;

            angulo = cont * (float)Math.PI / 180.0f;
            x = (float)Math.Cos(angulo) * 85;
            y = (float)Math.Sin(angulo) * 85;

            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0.0f, 0.0f);
                Gl.glVertex2f(x / 100.0f, y / 100.0f);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 360)
                cont = -6;

            cont -= 6;
            simpleOpenGlControl1.Refresh();
        }
    }
}
