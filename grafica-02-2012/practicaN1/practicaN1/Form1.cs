using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;

namespace practicaN1
{
    public partial class Form1 : Form
    {
        private int lado, i, MAXIMO;
        private const int DERECHA = 0, ABAJO = 1, IZQUIERDA = 2, ARRIBA = 3;
        private float[,] pts = new float[2, 21];
        Punto mostrar=new Punto();
        public Form1()
        {
            InitializeComponent();
            pts[0, 0] = 0.0f;
            pts[1, 0] = 0.0f;

            pts[0, 1] = 0.1f;
            pts[1, 1] = 0.0f;

            pts[0, 2] = 0.2f;
            pts[1, 2] = 0.0f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1.0f, 1.0f, 1.0f, 0.0f);
            lado = DERECHA;
            MAXIMO = 3;
            mostrar.punto();
            for (i = 0; i < 3; i++)
                mostrar.dibujar(pts[0, i], pts[1, i]);
            
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
           
            for (i = 0; i < MAXIMO; i++)
            {
                mostrar.dibujar(pts[0, i], pts[1, i]);
                if (mostrar.comido(pts[0, 0], pts[1, 0]))
                {
                    MAXIMO++;
                    mostrar.punto();
                }
            }
           
        }

        private void simpleOpenGlControl1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = MAXIMO; i > 0; i--)
            {
                pts[0, i] = pts[0, i - 1];
                pts[1, i] = pts[1, i - 1];
            }
            switch (e.KeyCode) {
                case Keys.Up: pts[1, 0] += 0.1f; lado = ARRIBA;  break;
                case Keys.Down: pts[1, 0] -= 0.1f; lado = ABAJO; break;
                case Keys.Left: pts[0, 0] -= 0.1f; lado = IZQUIERDA; break;
                case Keys.Right: pts[0, 0] += 0.1f; lado = DERECHA;  break;
            }            
            simpleOpenGlControl1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((pts[0, 0] < 1.5f && pts[0, 0] > -1.5f) && (pts[1, 0] < 1.5f && pts[1, 0] > -1.5f))
            {
                for (int i = MAXIMO; i > 0; i--) { 
                    pts[0, i] = pts[0, i-1];
                    pts[1, i] = pts[1, i-1];
                }

                switch (lado) {
                    case DERECHA: pts[0, 0] += 0.1f; break;
                    case ABAJO: pts[1, 0] += -0.1f; break;
                    case IZQUIERDA: pts[0, 0] += -0.1f; break;
                    case ARRIBA: pts[1, 0] += 0.1f; break;
                }

                simpleOpenGlControl1.Refresh();
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("game over", "fin");
                //this.Close();
            } 
        }
    }
}
