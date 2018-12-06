using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        private List<Punto> lista;
        private float x, y;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            lista=new List<Punto>();
        }
        private void ejeCoordenadas()
        {
            Gl.glColor3f(1.0f, 0.0f, 0.0f);
            Gl.glPointSize(1.0f);
            Gl.glBegin(Gl.GL_POINTS);
            for (float v = -1.0f; v <= 1.0f; v += 0.001f)
            {
                Gl.glVertex2f(0.0f,v);
                Gl.glVertex2f(v,0.0f);
            }
            Gl.glEnd();
        }
        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            ejeCoordenadas();          
            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].set();   
            }
        }

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {          
            float ancho = (float)simpleOpenGlControl1.Width / 2;
            float alto = (float)simpleOpenGlControl1.Height / 2;
            x = (e.X - ancho) / ancho;
            y = -(e.Y - alto) / alto;
            lista.Add(new Punto(x, y, (float)trackBar1.Value, button1.BackColor));
            simpleOpenGlControl1.Refresh();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }
    }
}