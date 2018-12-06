using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace Laboratorio4
{
    public partial class Form1 : Form
    {
        private List<Linea> l;
        private Punto p0, p1;
        private float x, y;
        private int contar;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            l = new List<Linea>();
            contar = 1;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            for (int i = 0; i < l.Count; i++)
            {
                l[i].setLineColorPoint();
            }
        }
        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            float ancho, alto;
            ancho = (float)simpleOpenGlControl1.Width/2;
            alto = (float)simpleOpenGlControl1.Height/2;
            x = ((float)e.X - ancho)/ancho;
            y = -((float)e.Y - alto)/alto;
            if (contar % 2 == 0)
            {
                p1 = new Punto(x, y, color);
                l.Add(new Linea(p0, p1));
                simpleOpenGlControl1.Refresh();
            }
            else
                p0 = new Punto(x, y, color);
            contar++;
        }

        private ColorOpenGL color;

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
                color=new ColorOpenGL((float)button1.BackColor.R/255,
                    (float)button1.BackColor.G/255,
                    (float)button1.BackColor.B/255);
            }
        }
    }
}