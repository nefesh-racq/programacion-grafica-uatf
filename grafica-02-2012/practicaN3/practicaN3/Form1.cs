using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace practicaN3
{
    public partial class Form1 : Form
    {
        Pregunta1 uno = new Pregunta1();
        Pregunta2 dos = new Pregunta2();
        Pregunta3 tres = new Pregunta3();
        Pregunta4 cuatro = new Pregunta4();
        Pregunta5 cinco = new Pregunta5();
        Pregunta6 seis = new Pregunta6();
        int figura = 0;

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
            Gl.glLoadIdentity();

            switch (figura) {
                case 1: uno.dibujar(); break;
                case 2: dos.dibujar(); break;
                case 3: tres.dibujar(); break;
                case 4: cuatro.dibujar(); break;
                case 5: cinco.dibujar(); break;
                case 6: seis.dibujar(); break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           figura = 1;
           simpleOpenGlControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            figura = 2;
            simpleOpenGlControl1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            figura = 4;
            simpleOpenGlControl1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            figura = 5;
            simpleOpenGlControl1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            figura = 6;
            simpleOpenGlControl1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            figura = 3;
            simpleOpenGlControl1.Refresh();
        }        
    }
}


