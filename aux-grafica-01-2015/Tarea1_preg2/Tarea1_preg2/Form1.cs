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
using Tao.Platform.Windows;

namespace Tarea1_preg2
{
    public partial class Form1 : Form
    {
        private Figura figura = new Figura(350);
        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            //Gl.glClearColor(0.5f, 0.5f, 0, 1);
            Gl.glClearColor(0, 0, 0, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            figura.Dibujar();
        }

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            float alto = simpleOpenGlControl1.Height / 2.0f;
            float ancho = simpleOpenGlControl1.Width / 2.0f;

            float x = (e.X - ancho) / ancho;
            float y = (e.Y - alto) / -alto;

            figura.listaPuntos.Add(new Punto(x * ancho * 2, y * alto * 2));
            figura.color = new Color(1, 0, 0);
            simpleOpenGlControl1.Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            figura.listaPuntos = new List<Punto>();
            simpleOpenGlControl1.Refresh();
        }

    }
}
