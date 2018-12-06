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

namespace Tarea4_preg2
{
    public partial class Form1 : Form
    {
        private Personaje p;
        private Timer t;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.3f, 0.8f, 0.2f, 1.0f);
            p = new Personaje();
            t = new Timer();

            t.Tick += new EventHandler(ciclo);
            t.Interval = 100;
            t.Enabled = true;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            p.dibujar();
        }

        public void ciclo(Object sender, EventArgs e)
        {
            p.mover();
            simpleOpenGlControl1.Refresh();
        }

    }
}
