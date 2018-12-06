using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tao.OpenGl;

namespace Tarea1_preg1
{
  
    public partial class Form1 : Form
    {
        private Figura figura = new Figura();

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 0, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            figura.Dibujar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            simpleOpenGlControl1.Refresh();
        }

    }
}
