using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/***************************/
using Tao.OpenGl;

namespace tareaN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 1, 0);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Agente obj = new Agente();

            obj.caminar(0, 0, 100, 50);
            //obj.figura(50, 0, 0);
            obj.evento_tiempo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
