using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
        }       

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Random r = new Random();
            for (int i = 0; i < 20; i++)
                circunferenciaEcuacion(r.Next(5, 20), r.Next(-100, 100), r.Next(-100, 100), new Color((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble()), new Color((float)r.NextDouble(), (float)r.NextDouble(), (float)r.NextDouble()));

        }
        public void setPixel(int x, int y)
        {
            float px, py;
            px = (float)x / 100;
            py = (float)y / 100;
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(px, py);
            Gl.glEnd();
        }
        private void circunferenciaEcuacion(int r,int posx,int posy,Color fondo, Color borde) {
            int y = r;
            for (int x = 0; x <= y; x++)
            {
                float val = (float)Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2));
                y = (int)val;
                puntosCircunferencia(x,y, posx,posy, fondo,borde);
            }
               
        }
        private void puntosCircunferencia(int x, int y,int posx,int posy, Color fondo, Color borde)
        {
            Gl.glColor3f(fondo.rojo,fondo.verde,fondo.azul);
                for (int i = -x; i <= x; i++)
                {
                    setPixel(i + posx, y + posy);
                    setPixel(i + posx, -y + posy);
                }
                for (int i = -y; i <= y;i++)
                {
                    setPixel(i + posx, x + posy);
                    setPixel(i + posx, -x + posy);
                }
                Gl.glColor3f(borde.rojo, borde.verde, borde.azul);

                setPixel(x + posx, y + posy);
                setPixel(y + posx, x + posy);
                setPixel(-y + posx, x + posy);
                setPixel(-x + posx, y + posy);

                setPixel(-x + posx, -y + posy);
                setPixel(-y + posx, -x + posy);
                setPixel(y + posx, -x + posy);
                setPixel(x + posx, -y + posy);
            
        }
       
    }
}
