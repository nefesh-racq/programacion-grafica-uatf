using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*********************************/
using Tao.OpenGl;

namespace practicaN3
{
    public partial class Form1 : Form
    {
        private int figura = 0;
        Pregunta1 uno = new Pregunta1();
        Pregunta dos = new Pregunta(100);

        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 1, 0);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            switch (figura)
            {
                case 1: uno.dibujar(); break;
                case 2: dos.dibujar();  break;
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
    }
}
