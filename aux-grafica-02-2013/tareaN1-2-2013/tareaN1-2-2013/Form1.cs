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

namespace tareaN1_2_2013
{
    public partial class Form1 : Form
    {
        int a = 10, inicioX = 0, inicioY = 0;
        int[][] puntos = {new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0},
                          new int[2]{0, 0}
                         };

        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            //Gl.glClearColor(0.1f, 0.1f, 0.1f, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glPointSize(6);
            Gl.glColor3f(1, 0, 0);

            label1.Text = string.Empty;
            label2.Text = string.Empty;

            if (a == 1)
            {
                if (indiceS < indiceM)
                {
                    if (k >= pasos)
                    {
                        rectaDDA(inicioX, inicioY, puntos[indiceS][0], puntos[indiceS][1]);
                        inicioX = puntos[indiceS][0];
                        inicioY = puntos[indiceS++][1];
                    }
                }

                a = 0;
            }
            
            /**
             * muestra el punto hecho por el mouse
             */
            for (int i = 0; i < indiceM; i++) {
                setPixel(puntos[i][0], puntos[i][1], 100);
            }


            /*
             * muestra el punto hecho por el algoritmo
             * **/
            setPixel((int)x, (int)y, 100);
        
            /**
             * mostrando los puntos que se generan y los del mouse
             */
            label1.Text = (int)x + ", " + (int)y;
            label2.Text = (int)(px * 100) + ", " + (int)(py * 100);

        }

        private void setPixel(int x, int y, int escala) {
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f((float)x / escala, (float)y / escala);
            Gl.glEnd();
        }


        /**************************************************************/
        int dx, dy, pasos, k = 0;
        float xincre, yincre, x = 0, y = 0;

        private void rectaDDA(int x0, int y0, int x1, int y1)
        {   
            dx = x1 - x0;
            dy = y1 - y0;
            pasos = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy); ;
            xincre = (float)dx / pasos;
            yincre = (float)dy / pasos;
            x = x0;
            y = y0;
            
            k = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (k < pasos)
            {
                x += xincre;
                y += yincre;
                k++;
                if (k >= pasos)
                  a = 1;
            }

            simpleOpenGlControl1.Refresh();
        }


        float px = 0, py = 0;
        int indiceM = 0, indiceS = 0;

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            int ancho = simpleOpenGlControl1.Width / 2;
            int alto = simpleOpenGlControl1.Height / 2;

            a = 1;
            px = (float)(e.X - ancho) / ancho;
            py = (float)(e.Y - alto) / -ancho;

            if (indiceM < 10)
            {
                puntos[indiceM][0] = (int)(px * 100);
                puntos[indiceM++][1] = (int)(py * 100);
            }

            simpleOpenGlControl1.Refresh();
        }
    }
}


/**
 * instrucciones para la pregunta 2
 */

//int x0 = -100, y0 = 100;
//int x1 = 100, y1 = 100;
//int cont = 0;

//while (++cont <= 20) {
//    rectaDDA(x0, y0, x1, y1);

//    x0 += 10;
//    y1 -= 10;
//}

//x0 = 100; y0 = 100;
//x1 = 100; y1 = -100;
//cont  = 0;
//while (++cont <= 20) {
//    rectaDDA(x0, y0, x1, y1);
//    x1 -= 10;
//    y0 -= 10;
//}


//x0 = 100; y0 = -100;
//x1 = -100; y1 = -100;
//cont = 0;
//while (++cont <= 20)
//{
//    rectaDDA(x0, y0, x1, y1);
//    x0 -= 10;
//    y1 += 10;
//}

//x0 = -100; y0 = -100;
//x1 = -100; y1 = 100;
//cont = 0;
//while (++cont <= 20)
//{
//    rectaDDA(x0, y0, x1, y1);
//    x1 += 10;
//    y0 += 10;
//}



///** cuadro del medio jejeje */

//x0 = -50; y0 = 50;
//x1 = 50; y1 = 50;
//cont = 0;
//while (++cont <= 11)
//{
//    rectaDDA(x0, y0, x1, y1);

//    x0 += 10;
//    y1 -= 10;
//}

//x0 = 50; y0 = 50;
//x1 = 50; y1 = -50;
//cont = 0;
//while (++cont <= 11)
//{
//    rectaDDA(x0, y0, x1, y1);
//    x1 -= 10;
//    y0 -= 10;
//}


//x0 = 50; y0 = -50;
//x1 = -50; y1 = -50;
//cont = 0;
//while (++cont <= 11)
//{
//    rectaDDA(x0, y0, x1, y1);
//    x0 -= 10;
//    y1 += 10;
//}

//x0 = -50; y0 = -50;
//x1 = -50; y1 = 50;
//cont = 0;
//while (++cont <= 11)
//{
//    rectaDDA(x0, y0, x1, y1);
//    x1 += 10;
//    y0 += 10;
//}