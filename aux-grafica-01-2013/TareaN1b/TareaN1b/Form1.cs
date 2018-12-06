using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*************************/
using Tao.OpenGl;

namespace TareaN1b
{
    public partial class Form1 : Form
    {                          // x, y
        private int[,] puntos = {{0, 0},    // punto 1
                                 {0, 0},    // punto 2
                                 {0, 0},    // punto 3
                                 {0, 0},    // punto 4
                                 {0, 0},    // punto 5
                                 {0, 0},    // punto 6
                                 {0, 0},    // punto 7
                                 {0, 0},    // punto 8
                                 {0, 0},    // punto 9
                                 {0, 0}};   // punto 10
        private int cont_puntos, dibujar;
        private const int PUNTOS = 1, POLIGONO = 2; 

        public Form1()
        {
            InitializeComponent();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 1, 0);
            cont_puntos = 0;
            dibujar = 0;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glPointSize(5);

            switch (dibujar) {
                case PUNTOS:
                    for (int i = 0; i < cont_puntos; i++)
                        setPixel(puntos[i, 0], puntos[i, 1], 100);
                    break;

                case POLIGONO:
                    Gl.glBegin(Gl.GL_LINE_STRIP);
                    for (int i = 0; i < cont_puntos; i++)
                        Gl.glVertex2f(puntos[i, 0] / 100.0f, puntos[i, 1] / 100.0f);

                    Gl.glVertex2f(puntos[0, 0] / 100.0f, puntos[0, 1] / 100.0f);
                    Gl.glEnd();
                    break;
            }
        }

        private void setPixel(int x, int y, int div)
        {
            Gl.glColor3f(0, 0, 0);

            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f((float)x / div, (float)y / div);
            Gl.glEnd();
        }

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            int indice = cont_puntos;
            float ancho = simpleOpenGlControl1.Width / 2;
            float alto = simpleOpenGlControl1.Height / 2;
            
            puntos[indice, 0] = (int)((e.X - ancho) / ancho * 100);
            puntos[indice, 1] = (int)((e.Y - alto) / -ancho * 100);
            ++cont_puntos;
            dibujar = PUNTOS;
            simpleOpenGlControl1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dibujar = POLIGONO;
            simpleOpenGlControl1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cont_puntos; i++) {
                puntos[i, 0] = 0;
                puntos[i, 1] = 0;
            }

            cont_puntos = 0;
            simpleOpenGlControl1.Refresh();
        }
    }
}
