using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*****************************/
using Tao.OpenGl;

namespace TareaN1a
{
    public partial class Form1 : Form
    {
        /*******************************/
        int _indice, _turno, _cont, _x, _y;
        int[] jugadas = {-1, -1, -1,
                         -1, -1, -1,
                         -1, -1, -1};
        int[][] posicion = {new int[2]{-70, 70},  new int[2]{0, 70},  new int[2]{70, 70},
                            new int[2]{-70, 0},   new int[2]{0, 0},   new int[2]{70, 0},
                            new int[2]{-70, -70}, new int[2]{0, -70}, new int[2]{70, -70}};
        int[] recordar = {-1, -1, -1, 
                          -1, -1, -1, 
                          -1, -1, -1};
        int ganador = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 1, 0);
            _turno = -1;
            _indice = 0;
            _x = _y = 0;
            _cont = 0;
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            rayas();
            compararRegion();

            for (int i = 0; i < _cont; i++)

                switch (i % 2) {
                    case 0:
                        circulo(posicion[recordar[i]]); break;
                    case 1:
                        equis(posicion[recordar[i]]); break;
                }

            if (_turno < 9) {
                int omitir = 0;

                for (int i = 0; i < _cont; i++)
                    if (recordar[i] == _indice) {
                        omitir = 1;
                        --_turno;
                        break;
                    }

                switch (_turno % 2)
                {
                    case 0:
                        if (omitir == 0) { circulo(posicion[_indice]); recordar[_cont++] = _indice; jugadas[_indice] = 0; } break;
                    case 1:
                        if (omitir == 0) { equis(posicion[_indice]); recordar[_cont++] = _indice; jugadas[_indice] = 1; } break;
                }
                ++_turno;

                if (_turno > 4)
                    quienGano();
            }
        }

        private void quienGanor()
        { 
            if (jugadas[0] != -1 && (jugadas[0] == jugadas[1] && jugadas[1] == jugadas[2])) ganador = jugadas[0];
            else if (jugadas[3] != -1 && (jugadas[3] == jugadas[4] && jugadas[4] == jugadas[5])) ganador = jugadas[3];
            else if (jugadas[6] != -1 && (jugadas[6] == jugadas[7] && jugadas[7] == jugadas[8])) ganador = jugadas[6];
            else if (jugadas[0] != -1 && (jugadas[0] == jugadas[4] && jugadas[4] == jugadas[8])) ganador = jugadas[0];
            else if (jugadas[6] != -1 && (jugadas[6] == jugadas[4] && jugadas[4] == jugadas[2])) ganador = jugadas[6];
            else if (jugadas[0] != -1 && (jugadas[0] == jugadas[3] && jugadas[3] == jugadas[6])) ganador = jugadas[0];
            else if (jugadas[1] != -1 && (jugadas[1] == jugadas[4] && jugadas[4] == jugadas[7])) ganador = jugadas[1];
            else if (jugadas[2] != -1 && (jugadas[2] == jugadas[5] && jugadas[5] == jugadas[8])) ganador = jugadas[2];

            switch (ganador) { 
                case 0:
                    label2.Text = "Fin del juego.\nGanaron los redondos\n"; _turno = 10; break;
                case 1:
                    label2.Text = "Fin del juego,\nGanaron las equis\n"; _turno = 10; break;
            }
        }

        private void compararRegion()
        {
            if (_y >= 35 && _y <= 98) {
                if (_x >= -98 && _x <= -35) _indice = 0;
                if (_x >= -31 && _x <= 31) _indice = 1;
                if (_x >= 35 && _x <= 98) _indice = 2;
            }

            if (_y >= -31 && _y <= 31) {
                if (_x >= -98 && _x <= -35) _indice = 3;
                if (_x >= -31 && _x <= 31) _indice = 4;
                if (_x >= 35 && _x <= 98) _indice = 5;
            }

            if (_y >= -98 && _y <= -35) {
                if (_x >= -98 && _x <= -35) _indice = 6;
                if (_x >= -31 && _x <= 31) _indice = 7;
                if (_x >= 35 && _x <= 98) _indice = 8;
            }
        }

        private void rayas()
        {
            for (int i = -100; i <= 100; i++) {

                for (int j = -101; j <= 100; j += 67) {
                    setPixel(i, j, 100);
                    setPixel(j, i, 100);
                }
            }
        }

        private void setPixel(int x, int y, int div)
        {
            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f((float)x / div, (float)y / div);
            Gl.glEnd();
        }

        private void circulo(int[] c)
        {
            float angulo, x, y;

            for (int i = 0; i <= 360; i++) {
                angulo = i * (float)Math.PI / 180.0f;
                x = ((float)Math.Cos(angulo) * 30) + c[0];
                y = ((float)Math.Sin(angulo) * 30) + c[1];
                setPixel((int)x, (int)y, 100);
            }
        }

        private void equis(int[] c)
        {
            float angulo, x, y;
            Gl.glColor3f(0, 0, 0);

            Gl.glBegin(Gl.GL_LINES);
            for (int i = -45; i <= 360; i += 90) {
                angulo = i * (float)Math.PI / 180.0f;
                x = ((float)Math.Cos(angulo) * 40) + c[0];
                y = ((float)Math.Sin(angulo) * 40) + c[1];
                Gl.glVertex2f((float)c[0] / 100.0f, (float)c[1] / 100.0f);
                Gl.glVertex2f(x / 100.0f, y / 100.0f);
            }
            Gl.glEnd();
        }

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            float ancho = simpleOpenGlControl1.Width / 2;
            float alto = simpleOpenGlControl1.Height / 2;

            _x = (int)((e.X - ancho) / ancho * 100);
            _y = (int)((e.Y - alto) / -ancho * 100);
            simpleOpenGlControl1.Refresh();
        }
    }
}
