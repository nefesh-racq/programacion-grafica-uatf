using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*********************/
using Tao.OpenGl;
using Tao.FreeGlut;

namespace TareaN7_2
{
    public partial class Form1 : Form
    {
        private int[][] _mapa = {new int[]{0, 0, 0, 0, 0, 1, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                 new int[]{0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                                };
        private float _x, _y;
        private int _indiceX = 5, _indiceY = 0,
            jugador = 1, ganador = 0;
        private int _posicionX, _posicionY,
            _puntosJugador1 = 0, _puntosJugador2 = 0;

        public Form1()
        {
            InitializeComponent();
            /*********************/
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 0, 1);
            
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_SINGLE | Glut.GLUT_RGB);

            Gl.glOrtho(-1, 1, 1, 1, 0.5f, 50.0f);

            luz();
        }

        private void luz()
        {
            float[] l_ambiente = new float[] { 0.75f, 0.75f, 0.75f, 1.0f };
            float[] l_difuso = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] l_brillo = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            float[] l_direccion = new float[] { 0.0f, 0.0f, -1.0f, 0.0f };

            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_AMBIENT, l_ambiente);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, l_difuso);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_SPECULAR, l_brillo);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, l_direccion);

            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_DEPTH_TEST);
        }

        private void esfera(int color)
        {
            float[] m_ambiente = new float[] { 0.0f, 0.0f, 0.0f, 1.0f };
            float[] m_difuso;
            float[] m_brillo = new float[] { 0.1f, 0.1f, 0.1f, 1.0f };

            if (color == 1)
                m_difuso = new float[] { 1.0f, 0, 0, 1.0f };
            else
                m_difuso = new float[] { 0, 1.0f, 0, 1.0f };

            
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_AMBIENT, m_ambiente);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_DIFFUSE, m_difuso);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, m_brillo);
            Gl.glMaterialf(Gl.GL_FRONT, Gl.GL_SHININESS, 100.0f);
            
            Glut.glutSolidSphere(0.1f, 36, 36);

        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
            Glu.gluLookAt(0, 0, 1, 0, 0, 0, 0, 1, 0);

            dibujarMapa();
            ganador = verificarGanador();

            if (ganador != 0)
            {
                if (ganador == 1)
                    _puntosJugador1++;

                if (ganador == 2)
                    _puntosJugador2++;

                lblPuntosRojo.Text = _puntosJugador1.ToString();
                lblPuntosVerde.Text = _puntosJugador2.ToString();

                MessageBox.Show("GANO JUGADOR " + ganador.ToString());
            }
        }

        private void dibujarMapa()
        { 
            int i = 0, j = 0;

            _y = 0.9f;

            while (_y > -1) {
                j = 0;
                Gl.glLoadIdentity();
                _x = -0.9f;

                while (_x < 1) {
                    Gl.glLoadIdentity();

                    switch (_mapa[i][j]) {
                        case 1: dibujarEsfera(1); break;
                        case 2: dibujarEsfera(2); break;
                    }

                    _x += 0.2f;

                    if (++j > 9)
                        j = 0;
                }

                _y -= 0.2f;

                if (++i > 9)
                    i = 0;
            }
        }

        private void dibujarEsfera(int color)
        {
            Gl.glPushMatrix();
                Gl.glTranslatef(_x, _y, 0);
                esfera(color);
            Gl.glPopMatrix();
        }

        private void simpleOpenGlControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                if (jugador == 1)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.A: if (_indiceX > 0)
                            {
                                _mapa[0][_indiceX] = 0;
                                _indiceX--;
                                _mapa[0][_indiceX] = jugador;
                            }
                            break;

                        case Keys.D: if (_indiceX < 9)
                            {
                                _mapa[0][_indiceX] = 0;
                                _indiceX++;
                                _mapa[0][_indiceX] = jugador;
                            }
                            break;

                        case Keys.S: timer1.Enabled = true; break;
                    }
                }
                else if (jugador == 2) {
                    switch (e.KeyCode)
                    {
                        case Keys.J: if (_indiceX > 0)
                            {
                                _mapa[0][_indiceX] = 0;
                                _indiceX--;
                                _mapa[0][_indiceX] = jugador;
                            }
                            break;

                        case Keys.L: if (_indiceX < 9)
                            {
                                _mapa[0][_indiceX] = 0;
                                _indiceX++;
                                _mapa[0][_indiceX] = jugador;
                            }
                            break;

                        case Keys.K: timer1.Enabled = true; break;
                    }
                }
            }
            simpleOpenGlControl1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((_indiceY + 1 <= 9) && (_mapa[_indiceY + 1][_indiceX] == 0))
            {
                _mapa[_indiceY][_indiceX] = 0;
                _indiceY++;
                _mapa[_indiceY][_indiceX] = jugador;
            }
            else
            {
                _mapa[_indiceY][_indiceX] = jugador;
                _posicionX = _indiceX;
                _posicionY = _indiceY;
                _indiceX = 5;       
                _indiceY = 0;

                jugador = (jugador == 1) ? 2 : 1;
                _mapa[_indiceY][_indiceX] = jugador;
                timer1.Enabled = false;
            }
            
            simpleOpenGlControl1.Refresh();
        }

        /******** comparaciones para verificar los ganadores **********
         */
        private int iguales = 1;

        private int verificarGanador()
        {
            if (timer1.Enabled == false)
            {
                iguales = 1;
                compararDerecha(_posicionX + 1);
                if (iguales == 4) return _mapa[_posicionY][_posicionX];

                compararIzquierda(_posicionX - 1);
                if (iguales == 4) return _mapa[_posicionY][_posicionX];

                iguales = 1;
                compararAbajo(_posicionY + 1);
                if (iguales == 4) return _mapa[_posicionY][_posicionX];

                iguales = 1;
                compararDiagonalPrincipalAbajo(_posicionX + 1, _posicionY + 1);
                if (iguales == 4) return _mapa[_posicionY][_posicionX];

                compararDiagonalPrincipalArriba(_posicionX - 1, _posicionY - 1);
                if (iguales == 4) return _mapa[_posicionY][_posicionX];

                iguales = 1;
                compararDiagonalSecundariaAbajo(_posicionX - 1, _posicionY + 1);
                if (iguales == 4) return _mapa[_posicionY][_posicionX];

                compararDiagonalSecundariaArriba(_posicionX + 1, _posicionY - 1);
                if (iguales == 4) return _mapa[_posicionY][_posicionX];
            }
            
            return 0;
        }

        private void compararDerecha(int x)
        {
            if (x < 10 && _mapa[_posicionY][_posicionX] == _mapa[_posicionY][x]) {
                iguales++;
                compararDerecha(x + 1);
            }
        }

        private void compararIzquierda(int x)
        {
            if (x >= 0 && _mapa[_posicionY][_posicionX] == _mapa[_posicionY][x]) {
                iguales++;
                compararIzquierda(x - 1);
            }
        }

        private void compararAbajo(int y)
        {
            if (y < 10 && _mapa[_posicionY][_posicionX] == _mapa[y][_posicionX]) {
                iguales++;
                compararAbajo(y + 1);
            }
        }

        private void compararDiagonalPrincipalAbajo(int x, int y)
        {
            if ((x < 10 && y < 10) && _mapa[_posicionY][_posicionX] == _mapa[y][x]) {
                iguales++;
                compararDiagonalPrincipalAbajo(x + 1, y +1);
            }
        }

        private void compararDiagonalPrincipalArriba(int x, int y)
        {
            if ((x >= 0 && y >= 0) && _mapa[_posicionY][_posicionX] == _mapa[y][x]) {
                iguales++;
                compararDiagonalPrincipalArriba(x - 1, y - 1);
            }
        }

        private void compararDiagonalSecundariaAbajo(int x, int y)
        {
            if ((x >= 0 && y < 10) && _mapa[_posicionY][_posicionX] == _mapa[y][x]) {
                iguales++;
                compararDiagonalSecundariaAbajo(x - 1, y + 1);
            }
        }

        private void compararDiagonalSecundariaArriba(int x, int y)
        {
            if ((x < 10 && y >= 0) && _mapa[_posicionY][_posicionX] == _mapa[y][x]) {
                iguales++;
                compararDiagonalSecundariaArriba(x + 1, y - 1);
            }
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) {
                
                for (int j = 0; j < 10; j++)
                    _mapa[i][j] = 0;
            }
            
            jugador = 1;
            _mapa[0][5] = jugador;

            //lblPuntosRojo.Text = "0";
            //lblPuntosVerde.Text = "0";
            simpleOpenGlControl1.Focus();
            simpleOpenGlControl1.Refresh();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAcercaDe obj = new FAcercaDe();

            obj.ShowDialog();
        }

        private void instruccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FInstrucciones obj = new FInstrucciones();

            obj.ShowDialog();
        }
    }
}
