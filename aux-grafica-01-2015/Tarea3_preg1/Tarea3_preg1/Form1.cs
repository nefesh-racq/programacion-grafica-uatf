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

namespace Tarea3_preg1
{
    public partial class Form1 : Form
    {
        public int Girar = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            //Gl.glClearColor(1, 1, 1, 1);
            //Gl.glClearColor(1, 0, 1, 1);
            Gl.glClearColor(0, 0.6f, 0, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glRotatef(Girar, 0, 0, 1);
            FiguraFinal();
        }

        private void FiguraFinal()
        {
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            Gl.glRotatef(45, 0, 0, 1);
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            Gl.glRotatef(45, 0, 0, 1);
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            Gl.glRotatef(45, 0, 0, 1);
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            Gl.glRotatef(45, 0, 0, 1);
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            Gl.glRotatef(45, 0, 0, 1);
            FiguraCompuesta();


            Gl.glScalef(0.8f, 0.8f, 0);
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            Gl.glRotatef(45, 0, 0, 1);
            FiguraCompuesta();

            Gl.glScalef(0.8f, 0.8f, 0);
            Gl.glRotatef(45, 0, 0, 1);
            FiguraCompuesta();
        }

        private void FiguraCompuesta()
        {
            Gl.glColor3f(0, 0, 1);
            Figura();

            Gl.glColor3f(1, 0, 0);
            Gl.glRotatef(45, 0, 0, 1);
            Figura();
        }

        private void Figura()
        {
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex2f(0.7f, 0.7f);
                Gl.glVertex2f(-0.7f, 0.7f);
                Gl.glVertex2f(-0.7f, -0.7f);
                Gl.glVertex2f(0.7f, -0.7f);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++Girar >= 360)
                Girar = 0;

            simpleOpenGlControl1.Refresh();
        }

    }
}
