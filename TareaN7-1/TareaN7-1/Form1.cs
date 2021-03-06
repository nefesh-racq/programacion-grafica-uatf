﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/********************************/
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.IO;
using System.Drawing.Imaging;

namespace TareaN7_1
{
    public partial class Form1 : Form
    {
        private int[][] _mapa = { new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{0, 0},
                                  new int[]{1, 0}
                                };
        private float _x, _y;
        private int _indiceX = 0, jugador = 1,
            saltos = 0;
        private int[] _velocidades = {0, /*900, 800, 700, 600, 500, */400, 300, 200, 100, 90, 80, 70, 60, 50, 40};
        private int _velocidad = 5, 
            _kilometros = 0,
            _metros = 0;
        Random aleatorio = new Random();
        const int DISTANCIA_KM = 15;
        static int _cocheJugador;
        static int _cocheObstaculo;
        static int _pista0;
        static int _pista1;
        static int _explocionCoche;

        public Form1()
        {
            InitializeComponent();
            /****************************/
            
            tVelocidad.Text = _velocidad.ToString();
            lblKilometros.Text = "0";
            lblMetros.Text = "0";
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();

            Gl.glClearColor(0, 0, 0, 1);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
           // Gl.glEnable(Gl.GL_CULL_FACE);

            //cargarTextura(@"cocheJugador.png", out _cocheJugador);
            //cargarTextura(@"cocheObstaculo.png", out _cocheObstaculo);
            //cargarTextura(@"pista0.png", out _pista0);
            //cargarTextura(@"pista1.png", out _pista1);
            //cargarTextura(@"explocionCoche.png", out _explocionCoche);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // bucle sencillo del juego
            dibujarMapa();
            verificarChoque();
            recorrerCamino();
        }

        bool _pista = true;

        private void dibujarMapa()
        {
        
            _x = -0.8f;
            _y = 1;
            int i = 0, j = 0;

            while (_y > -0.9f) {
                _x = -0.8f;
                Gl.glLoadIdentity();

                while (_x < 0) {
                    Gl.glLoadIdentity();
                    switch (_mapa[i][j]) {
                        case 1: dibujarAuto1(); break;
                        case 2:  dibujarAuto2(); break;
                        case 3:  dibujarAuto3(); break;
                    }

                    _x += 0.5f;

                    if (++j > 1)
                        j = 0;
                }

                _y -= 0.2f;

                if (++i > 9)
                    i = 0;
            }


            Gl.glPushMatrix();
            Gl.glEnable(Gl.GL_TEXTURE_2D);

            if (_pista)
            {
                _pista0 = 0;
                cargarTextura(@"pista0.png", out _pista0);
                Gl.glBindTexture(0, _pista0);
            }
            else
            {
                _pista1 = 0;
                cargarTextura(@"pista1.png", out _pista1);
                Gl.glBindTexture(0, _pista1);
            }

            _pista = !_pista;

            Gl.glBegin(Gl.GL_QUADS);
            Gl.glTexCoord3d(0, 0, -0.5f); Gl.glVertex3f(0.0f, 1f, 0.5f);
            Gl.glTexCoord3d(1, 0, -0.5f); Gl.glVertex3f(-0.95f, 1f, 0.5f);
            Gl.glTexCoord3d(1, 1, -0.5f); Gl.glVertex3f(-0.95f, -0.95f, 0.5f);
            Gl.glTexCoord3d(0, 1, -0.5f); Gl.glVertex3f(0.0f, -0.95f, 0.5f);
            Gl.glEnd();
            Gl.glDisable(Gl.GL_TEXTURE_2D);
            Gl.glPopMatrix();
        }


        private void dibujarAuto1()
        {
                Gl.glPushMatrix();
                Gl.glTranslatef(_x, _y, 0);
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                _cocheJugador = 0;
                cargarTextura(@"cocheJugador.png", out _cocheJugador);
                Gl.glBindTexture(0, _cocheJugador);
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord3d(0, 0, 1); Gl.glVertex3f(0.1f, 0.15f, -0.1f);
                Gl.glTexCoord3d(1, 0, 1); Gl.glVertex3f(-0.1f, 0.15f, -0.1f);
                Gl.glTexCoord3d(1, 1, 1); Gl.glVertex3f(-0.1f, -0.15f, -0.1f);
                Gl.glTexCoord3d(0, 1, 1); Gl.glVertex3f(0.1f, -0.15f, -0.1f);
                Gl.glEnd();
                Gl.glDisable(Gl.GL_TEXTURE_2D);
                Gl.glPopMatrix();
        }

        private void dibujarAuto2()
        {
                Gl.glPushMatrix();
                Gl.glTranslatef(_x, _y, 0);
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                _cocheObstaculo = 0;
                cargarTextura(@"cocheObstaculo.png", out _cocheObstaculo);
                Gl.glBindTexture(0, _cocheObstaculo);
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord3d(0, 0, 1); Gl.glVertex3f(0.1f, 0.15f, -0.1f);
                Gl.glTexCoord3d(1, 0, 1); Gl.glVertex3f(-0.1f, 0.15f, -0.1f);
                Gl.glTexCoord3d(1, 1, 1); Gl.glVertex3f(-0.1f, -0.15f, -0.1f);
                Gl.glTexCoord3d(0, 1, 1); Gl.glVertex3f(0.1f, -0.15f, -0.1f);
                Gl.glEnd();
                Gl.glDisable(Gl.GL_TEXTURE_2D);
                Gl.glPopMatrix();
        }

        private void dibujarAuto3()
        {
                Gl.glPushMatrix();
                Gl.glTranslatef(_x, _y, 0);
                Gl.glEnable(Gl.GL_TEXTURE_2D);
                _explocionCoche = 0;
                cargarTextura(@"explocionCoche.png", out _explocionCoche);
                Gl.glBindTexture(0, _explocionCoche);
                Gl.glBegin(Gl.GL_QUADS);
                Gl.glTexCoord3d(0, 0, 1); Gl.glVertex3f(0.1f, 0.15f, -0.1f);
                Gl.glTexCoord3d(1, 0, 1); Gl.glVertex3f(-0.1f, 0.15f, -0.1f);
                Gl.glTexCoord3d(1, 1, 1); Gl.glVertex3f(-0.1f, -0.15f, -0.1f);
                Gl.glTexCoord3d(0, 1, 1); Gl.glVertex3f(0.1f, -0.15f, -0.1f);
                Gl.glEnd();
                Gl.glDisable(Gl.GL_TEXTURE_2D);
                Gl.glPopMatrix();
            }

           

        private void recorrerCamino()
        {
            int choque0 = _mapa[8][0],
                choque1 = _mapa[8][1];

            for (int indice = 8; indice > 0; indice--) {
                _mapa[indice][0] = _mapa[indice - 1][0];
                _mapa[indice][1] = _mapa[indice - 1][1];
            }

            _mapa[0][0] = 0;
            _mapa[0][1] = 0;

            _mapa[9][0] += choque0;
            _mapa[9][1] += choque1;

            if (++saltos == 4)
            {
                nuevoAuto();
                saltos = 0;
            }
        }

        private void verificarChoque()
        {
            if (_mapa[9][0] == 3 || _mapa[9][1] == 3)
            {
                timer1.Enabled = false;
                MessageBox.Show("PERDISTE!!!");
            }
            else {
                if (_mapa[9][0] == 2)
                    _mapa[9][0] = 0;

                if (_mapa[9][1] == 2)
                _mapa[9][1] = 0;
            }
        }

        private void nuevoAuto()
        {
            if (_kilometros < DISTANCIA_KM && _metros < 1000)
            {
                int x = aleatorio.Next(0, 2);

                _mapa[0][x] = 2;
                _mapa[0][1 - x] = 0;
            }
            else {
                _mapa[0][0] = 4;
                _mapa[0][1] = 4;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((_metros += 10) > 999) {
                _metros = 0;
                ++_kilometros;
            }

            if (_kilometros > DISTANCIA_KM && _metros > 0) {
                timer1.Enabled = false;
                MessageBox.Show("GANASTE!!!");
            }

            lblKilometros.Text = _kilometros.ToString();
            lblMetros.Text = _metros.ToString();
            simpleOpenGlControl1.Refresh();
        }

        private void simpleOpenGlControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) {
                case Keys.A: if (_indiceX > 0) { 
                        _mapa[9][_indiceX] = 0; 
                        _indiceX--; 
                        _mapa[9][_indiceX] = jugador; 
                    }
                    break;

                case Keys.D: if (_indiceX < 1) {
                        _mapa[9][_indiceX] = 0;
                        _indiceX++;
                        _mapa[9][_indiceX] = jugador;
                    }
                    break;
            }

           // simpleOpenGlControl1.Refresh();
        }

        private void bIniciarJuego_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) {
                _mapa[i][0] = 0;
                _mapa[i][1] = 0;
            }

            _mapa[9][0] = jugador;
            _indiceX = 0;
            timer1.Enabled = true;
            timer1.Interval = _velocidades[_velocidad];
            lblMetros.Text ="0";
            lblKilometros.Text = "0";
            _kilometros = 0;
            _metros = 0;

            simpleOpenGlControl1.Focus();
        }

        private void bMenosVelocidad_Click(object sender, EventArgs e)
        {
            if (--_velocidad < 1)
                _velocidad = 1;

            tVelocidad.Text = _velocidad.ToString();
        }

        private void bMasVelocidad_Click(object sender, EventArgs e)
        {
            if (++_velocidad > 10)
                _velocidad = 10;

            tVelocidad.Text = _velocidad.ToString();
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



        /************************************
         * 
         * manejo de texturas */
        //private void dibujarAuto(int color)
        //{
        //    if (color == 1)
        //        Gl.glColor3f(1, 0, 0);
        //    else
        //        Gl.glColor3f(0, 1, 0);

        //    Gl.glPointSize(5);

        //    Gl.glPushMatrix();
        //        Gl.glTranslatef(_x, _y, 0);
        //        Gl.glBegin(Gl.GL_POINTS);
        //            Gl.glVertex2f(0, 0);
        //        Gl.glEnd();
        //    Gl.glPopMatrix();
        //}


        private void cargarTextura(string archivo, out int imagen)
        {
            Bitmap img = cargarBitMap(archivo);

            if (img != null)
            {
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                Rectangle rectangulo = new Rectangle(0, 0, img.Width, img.Height);
                BitmapData bitmapDato = img.LockBits(rectangulo, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

                Gl.glGenTextures(1, out imagen);
                Gl.glEnable(Gl.GL_COLOR_MATERIAL);
                Gl.glBindTexture(Gl.GL_TEXTURE_2D, imagen);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);
                Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MIN_FILTER, Gl.GL_NEAREST);
                Gl.glTexImage2D(Gl.GL_TEXTURE_2D, 0, Gl.GL_RGB8, img.Width, img.Height, 0, Gl.GL_BGR, Gl.GL_UNSIGNED_BYTE, bitmapDato.Scan0);
            }
            else
                imagen = 0;
        }

        private Bitmap cargarBitMap(string archivo)
        {
            if (archivo == null || archivo == string.Empty) return null;
            if (!File.Exists(archivo)) return null;
            if (File.Exists(archivo)) return new Bitmap(archivo);
            return null;
        }
    }
}
