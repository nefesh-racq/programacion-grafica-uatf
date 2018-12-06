using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);


            float x, y;
            y = 0.5f;
            x = 0;
            while (x < y)
            {
                y = (float)Math.Sqrt(Math.Pow(0.5f, 2)
                    - Math.Pow(x, 2));
                puntoCircunferencia(x, y, 0, 0);
                x += 0.01f;
            }

            if (click)
                dibujaClick();
            else
                sigueMouse();
        }

        private void dibujaClick()
        {
            Gl.glColor3f(0.66f, 0.99f, 0.52f);
            for (float rad = 0.0f; rad < 0.03;rad+=0.001f )
                circunferenciaEcuacion(rad, mx, my); 
        }

        private void sigueMouse()
        {
            switch(intervalo)
            {
                case 3: Gl.glColor3f(0.66f, 0.99f, 0.52f); 
                        circunferenciaEcuacion(0.02f, mx, my); 
                        break;
                    case 2: Gl.glColor3f(0.54f, 0.99f, 0.36f); 
                        circunferenciaEcuacion(0.04f, mx, my); 
                        break;
                    case 1: Gl.glColor3f(0.35f, 0.99f, 0.08f); 
                        circunferenciaEcuacion(0.06f, mx, my); 
                        break;
                    case 0: Gl.glColor3f(0.25f, 0.99f, 0.01f); 
                        circunferenciaEcuacion(0.08f, mx, my); 
                        break;
            }
        }

        private void circunferenciaEcuacion(float radio,float xc,float yc) 
        { 
            float x,y;
            y = radio;
            x=0;
            while (x < y)
            {
                y = (float)Math.Sqrt(Math.Pow(radio, 2) 
                    - Math.Pow(x, 2));
                puntoCircunferencia(x,y,xc,yc);
                x += 0.01f;
            }
        }
        // x^2 + y^2 = r^2

        // y = raiz(r^2 - x^2)
        private void puntoCircunferencia(float x,float y,float xc,float yc)
        {
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(x + xc, y + yc);
            Gl.glVertex2f(y + xc, x + yc);
            Gl.glVertex2f(-x + xc, y + yc);
            Gl.glVertex2f(-y + xc, x + yc);
            Gl.glVertex2f(x + xc, -y + yc);
            Gl.glVertex2f(y + xc, -x + yc);
            Gl.glVertex2f(-x + xc, -y + yc);
            Gl.glVertex2f(-y + xc, -x + yc);
            Gl.glEnd();
        }
        float mx, my;
        private void simpleOpenGlControl1_MouseMove(object sender, MouseEventArgs e)
        {
            float ancho = simpleOpenGlControl1.Width/2;
            float alto = simpleOpenGlControl1.Height/2;
            mx = (e.X - ancho) / ancho;
            my = -(e.Y - alto) / alto;
            //simpleOpenGlControl1.Refresh();
        }
        int intervalo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (intervalo > 3)
                intervalo = 0;
            else
                intervalo += 1;
            simpleOpenGlControl1.Refresh();
        }

        bool click;
        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            float ancho = simpleOpenGlControl1.Width / 2;
            float alto = simpleOpenGlControl1.Height / 2;
            mx = (e.X - ancho) / ancho;
            my = -(e.Y - alto) / alto;
            if (click)
                click = false;
            else
                click = true;
            //simpleOpenGlControl1.Refresh();
        }
    }
}