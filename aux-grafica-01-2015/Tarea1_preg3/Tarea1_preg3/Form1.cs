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

namespace Tarea1_preg3
{
    public partial class Form1 : Form
    {
        private Figura figura = new Figura(100);
        private int indice = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.5f, 0.5f, 0, 1);
            indice = 0;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            

            foreach (Punto row in figura.listaPuntos)
            {
                row.DibujarPunto(100);
            }
            
            Gl.glColor3f(1, 0, 0);
            Gl.glPointSize(10);
            
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f(figura.linea.listaRuta[indice].X, figura.linea.listaRuta[indice].Y);
            Gl.glEnd();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++indice >= figura.linea.listaRuta.Count)
                indice = 0;

            simpleOpenGlControl1.Refresh();
        }

        private void btnGenerarNew_Click(object sender, EventArgs e)
        {
            figura.CargarCamino();
            indice = 0;
            simpleOpenGlControl1.Refresh();
        }

    }
}
