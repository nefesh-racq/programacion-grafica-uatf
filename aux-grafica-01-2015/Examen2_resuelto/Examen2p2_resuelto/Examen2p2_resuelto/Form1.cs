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

namespace Examen2p2_resuelto
{
    public partial class Form1 : Form
    {
        private float a = 0, b = 0, c = 0, d = 0;
        private float[][] colores ={new float[3]{1, 1, 1},  // 0  color blanco al inicio
                                    new float[3]{1, 0, 0},  // 1
                                    new float[3]{1, 1, 0},  // 2
                                    new float[3]{0, 0, 1},  // 3
                                    new float[3]{0, 1, 0}   // 4
                                    };
        private int indice = 0;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0f, 0.1f, 0.2f, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            FIgura();
        }

        private void FIgura()
        {
            float angulo, x, y;

            Gl.glBegin(Gl.GL_LINES);
            // cambiado a decimales para que se vea de un color mas solido
            for (float i = 0; i <= 360; i += 0.2f)
            {
                angulo = i * (float)Math.PI / 180.0f;
                x = (float)Math.Cos(angulo);
                y = (float)Math.Sin(angulo);

                // eh añadido los else para el color blanco
                if (i <= a && i > 0)
                    indice = 1;
                else if (i <= a + b && i >= a)
                    indice = 2;
                else if (i <= a + b + c && i >= a + b)
                    indice = 3;
                else if (i <= a + b + c + d && i >= a + b + c)
                    indice = 4;
                else
                    indice = 0;

                Gl.glColor3fv(colores[indice]);
                Gl.glVertex2f(0, 0);
                Gl.glVertex2f(x, y);
            }
            Gl.glEnd();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // recuperamos los valores de los txt
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = Convert.ToInt32(txtC.Text);
            d = Convert.ToInt32(txtD.Text);

            // calculamos los porcenajes
            a = 360 * (a / 100.0f);
            b = 360 * (b / 100.0f);
            c = 360 * (c / 100.0f);
            d = 360 * (d / 100.0f);

            // muestra el porcentaje en los txt de colores
            txtAp.Text = a + " °";
            txtBp.Text = b + " °";
            txtCp.Text = c + " °";
            txtDp.Text = d + " °";

            simpleOpenGlControl1.Refresh();
        }

        // controla que solo se introdusca numeros en el primer textbox
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
        
    }
}
