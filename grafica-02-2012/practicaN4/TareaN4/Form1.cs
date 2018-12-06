using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace TareaN4
{
    public partial class Form1 : Form
    {
        private float mouseX, mouseY;
        private Punto ini = new Punto();
  
        public Form1()
        {
            InitializeComponent();
            ini = null;
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glColor3d(0.0f, 0.0f, 0.0f);
            Gl.glPointSize(5);
            Gl.glBegin(Gl.GL_POINTS);
            Punto punto = ini;
            while (punto != null)
            {
                Gl.glVertex2d(punto.x, punto.y);
                punto = punto.sgte;
            }
            Gl.glEnd();
        }

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            float ancho = simpleOpenGlControl1.Width / 2;
            float alto = simpleOpenGlControl1.Height / 2;
            mouseX = (float)(e.X - ancho) / ancho;
            mouseY = (float)(e.Y - alto) / -ancho;
            insertar();
            simpleOpenGlControl1.Refresh();
        }

        private void insertar()
        {
            Punto nuevo = new Punto();
            nuevo.x = mouseX;
            nuevo.y = mouseY;
            if (ini == null)
                ini = nuevo; 
            else
            {
                Punto aux = ini;
                while (aux.sgte != null)
                    aux = aux.sgte;
                aux.sgte = nuevo;
            }
        }
    }
}
