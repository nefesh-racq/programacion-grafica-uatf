using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/********************************/
using Tao.OpenGl;

namespace tareaN1_2_2013p3
{
    public partial class Form1 : Form
    {
        Estrategia recta = new Estrategia();

        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            recta.rectaDDA(0, 0, 50, 50);
        }

        
    }
}
