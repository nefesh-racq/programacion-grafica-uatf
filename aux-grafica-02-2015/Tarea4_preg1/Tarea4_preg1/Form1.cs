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

namespace Tarea4_preg1
{
    public partial class Form1 : Form
    {
        private Circulo c;
        private Timer t;
        private List<Circulo> list;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.4f, 0.4f, 0.4f, 1.0f);

            Random r = new Random();
            //c = new Circulo(r);
            t = new Timer();

            t.Interval = 100;
            t.Enabled = true;
            t.Tick += new EventHandler(ciclo);

            list = new List<Circulo>();
    
            for (int i = 0; i < 8; i++)
            {
                list.Add(new Circulo(r));
            }
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();
            //c.dibujar();
            foreach (Circulo it in list)
                it.dibujar();
        }

        private void ciclo(Object sender, EventArgs e)
        {
            //c.escalar();
            foreach (Circulo it in list)
                it.escalar();

            simpleOpenGlControl1.Refresh();
        }

    }
}
