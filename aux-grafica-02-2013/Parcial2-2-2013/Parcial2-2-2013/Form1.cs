using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/***********************/
using Tao.OpenGl;

namespace Parcial2_2_2013
{ 
    enum Color
    {
        Rojo,       // 0
        Amarillo,   // 1
        Verde,      // 2
        Azul
    };

    public partial class Form1 : Form
    {
        private int altoBarra1 = 20,
                    altoBarra2 = 10,
                    altoBarra3 = 5,
                    altoBarra4 = 15;
        private float[][] colores = { new float[3]{1, 0, 0},   // rojo
                                      new float[3]{1, 1, 0},   // amarillo
                                      new float[3]{0, 1, 0},   // verde
                                      new float[3]{0, 0, 1},   // azul
                                    };
    
        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 1, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glTranslated(0, -1, 0);

            barra(Color.Rojo, altoBarra1);

            Gl.glTranslated(4 / 10.0f, 0, 0);
            barra(Color.Amarillo, altoBarra2);

            Gl.glTranslated(4 / 10.0f, 0, 0);
            barra(Color.Verde, altoBarra3);

            Gl.glTranslated(4 / 10.0f, 0, 0);
            barra(Color.Azul, altoBarra4);
        }

        private void barra(Color color, int altura)
        {
            Gl.glColor3fv(colores[Convert.ToInt32(color)]);

            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex2f(-7 / 10.0f, 0);
                Gl.glVertex2f(-5 / 10.0f, 0);
                Gl.glVertex2f(-5 / 10.0f, altura / 10.0f);
                Gl.glVertex2f(-7 / 10.0f, altura / 10.0f);
            Gl.glEnd();
        }

        private void txtBarraRoja_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBarraRoja.Text != string.Empty)
            {
                altoBarra1 = Convert.ToInt32(txtBarraRoja.Text);
                simpleOpenGlControl1.Refresh();
            }
        }

        private void txtBarraAmarilla_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBarraAmarilla.Text != string.Empty)
            {
                altoBarra2 = Convert.ToInt32(txtBarraAmarilla.Text);
                simpleOpenGlControl1.Refresh();
            }
        }
    }
}
