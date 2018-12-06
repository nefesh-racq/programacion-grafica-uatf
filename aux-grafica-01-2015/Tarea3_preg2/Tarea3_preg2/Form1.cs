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

namespace Tarea3_preg2
{
    public partial class Form1 : Form
    {
        private byte[][] Mapa = { new byte[3]{1, 0, 0},
                                  new byte[3]{0, 0, 0},
                                  new byte[3]{0, 0, 0}
                                 };
        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 0, 1, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Matriz();
        }

        private void Matriz()
        {
            int i = 0, j = 0;

            for (float y = 0.6f; y >= -0.6f; y -= 0.6f)
            {
                for (float x = -0.6f; x <= 0.6f; x += 0.6f)
                {
                    Gl.glLoadIdentity();
                    Gl.glTranslatef(x, y, 0);

                    if (Mapa[i][j++] == 1)
                        Gl.glScalef(4, 4, 0);

                    Cuadrado();
                }

                i++;
                j = 0;
            }
        }

        private void Cuadrado()
        {
            Gl.glColor3f(1f, 0.8f, 0);
            Gl.glBegin(Gl.GL_QUADS);
                Gl.glVertex2f(0.1f, 0.1f);
                Gl.glVertex2f(-0.1f, 0.1f);
                Gl.glVertex2f(-0.1f, -0.1f);
                Gl.glVertex2f(0.1f, -0.1f);
            Gl.glEnd();
        }

        /*
         * controlamos que se muevan el cuadrado
         * */

        private int col = 0;
        private int fil = 0;

        private void simpleOpenGlControl1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: 
                    if (fil > 0)
                    {
                        Mapa[fil][col] = 0;
                        fil--;
                        Mapa[fil][col] = 1;
                    }
                    break;
                case Keys.Down:
                    if (fil < 2)
                    {
                        Mapa[fil][col] = 0;
                        fil++;
                        Mapa[fil][col] = 1;
                    }
                    break;
                case Keys.Left:
                    if (col > 0)
                    {
                        Mapa[fil][col] = 0;
                        col--;
                        Mapa[fil][col] = 1;
                    }
                    break;
                case Keys.Right:
                    if (col < 2)
                    {
                        Mapa[fil][col] = 0;
                        col++;
                        Mapa[fil][col] = 1;
                    }
                    break;
            }

            simpleOpenGlControl1.Refresh();
        }

    }
}

