using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/******************************/
using Tao.Platform.Windows;
using Tao.OpenGl;

namespace circuloBresenham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /***************************************/
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0, 0, 0, 0);
        }

        float px = 0;
        float py = 0;
        int radio = 50;
        float pxx = 0;
        float pyy = 0;
        float incx = 8.23f;
        float incy = 12.67f;
        int escala = 300;

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glViewport(0, 0, simpleOpenGlControl1.Width, simpleOpenGlControl1.Height);
            Gl.glPointSize(2);
            Gl.glLoadIdentity();
            /*float a = 168 / 255;
            float b = 126 / 255;
            float c = 113 / 255;
            Gl.glColor3f(a,b,c);*/
            float color = 0;
            float colorcito = 1f / 50;
            Gl.glColor3f(1, 0, 0);

            //rebote//
            if (pxx >= escala - (radio + 100))
                incx = -incx;


            //rebote//
            if (pyy >= escala - (radio + 100))
                incy = -incy;


            //rebote//
            if (pxx <= -escala + (radio + 100))
                incx = -incx;

            //rebote//
            if (pyy <= -escala + (radio + 100))
                incy = -incy;
            pxx += incx;
            pyy += incy;

            for (int i = 0; i <= 50; i++)
            {
                Gl.glColor3f(color, 0, 0);
                circulo_bresenham(pxx, pyy, radio + i);
                color += colorcito;
            }
            for (int i = 50; i <= 100; i++)
            {
                Gl.glColor3f(color, 0, 0);
                circulo_bresenham(pxx, pyy, radio + i);
                color -= colorcito;
            }
        }

        private void circulo_bresenham(float cx, float cy, int radio1)
        {
            int x = 0;
            int y = radio1;
            int p = 3 / 2 * radio1;
            while (x <= y)
            {
                puntos_circulo(x, y, cx, cy);
                if (p >= 0)
                {
                    p = p - (4 * y) + (4 * x) + 10;
                    y--;
                }
                else
                    p = p + (4 * x) + 6;
                x++;
            }
        }
        private void puntos_circulo(int x, int y, float px, float py)
        {
            pixeles(x + px, y + py);
            pixeles(y + px, x + py);
            pixeles(x + px, -y + py);
            pixeles(y + px, -x + py);
            pixeles(-x + px, y + py);
            pixeles(-y + px, x + py);
            pixeles(-x + px, -y + py);
            pixeles(-y + px, -x + py);
        }
        private void pixeles(float x, float y)
        {
            float px, py;
            px = x / escala;
            py = y / escala;
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(px, py);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simpleOpenGlControl1.Refresh();
        }
    }
}
