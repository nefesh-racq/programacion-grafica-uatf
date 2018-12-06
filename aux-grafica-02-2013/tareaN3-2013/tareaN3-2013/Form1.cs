using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/********************************/
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace tareaN3_2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();
            //Gl.glClearColor(1, 1, 1, 1);
        }


        private void dado()
        {
            //Gl.glPointSize(5);

            Gl.glEnable(Gl.GL_CULL_FACE);

            //// chimenea
            //Gl.glBegin(Gl.GL_QUADS);
            //    // lado izquierdo
            //    Gl.glColor3f(0.65f, 0.7f, 0.7f);      // mostasa
            //    Gl.glVertex3f(-0.85f, -0.3f, -0.1f);    // p3
            //    Gl.glVertex3f(-0.85f, 0.65f, -0.1f);     // p2
            //    Gl.glVertex3f(-0.85f, 0.65f, 0.1f);      // p8
            //    Gl.glVertex3f(-0.85f, -0.3f, 0.1f);     // p7  

            //    // lado frente
            //    Gl.glColor3f(0.7f, 0.7f, 0.7f);      // mostasa
            //    Gl.glVertex3f(-0.65f, 0.65f, -0.1f);      // p1
            //    Gl.glVertex3f(-0.85f, 0.65f, -0.1f);     // p2
            //    Gl.glVertex3f(-0.85f, -0.3f, -0.1f);    // p3
            //    Gl.glVertex3f(-0.65f, -0.3f, -0.1f);     // p4

            //    // lado derecho
            //    Gl.glColor3f(0.7f, 0.7f, 0.7f);      // mostasa
            //    Gl.glVertex3f(-0.65f, -0.3f, -0.1f);    // p3
            //    Gl.glVertex3f(-0.65f, -0.3f, 0.1f);     // p7 
            //    Gl.glVertex3f(-0.65f, 0.65f, 0.1f);      // p8
            //    Gl.glVertex3f(-0.65f, 0.65f, -0.1f);     // p2
            
            //    // lado atras
            //    Gl.glColor3f(0.7f, 0.7f, 0.7f);      // mostasa
            //    Gl.glVertex3f(-0.65f, 0.65f, 0.1f);      // p1
            //    Gl.glVertex3f(-0.65f, -0.3f, 0.1f);     // p4
            //    Gl.glVertex3f(-0.85f, -0.3f, 0.1f);    // p3
            //    Gl.glVertex3f(-0.85f, 0.65f, 0.1f);     // p2

            //    //tapita
            //    Gl.glColor3f(0.7f, 0.7f, 0.7f);      // mostasa
            //    Gl.glVertex3f(-0.85f, 0.65f, -0.1f);     // p2
            //    Gl.glVertex3f(-0.65f, 0.65f, -0.1f);     // p2
            //    Gl.glVertex3f(-0.65f, 0.65f, 0.1f);      // p8
            //    Gl.glVertex3f(-0.85f, 0.65f, 0.1f);      // p8
            //Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
                // frente
                Gl.glColor3f(0.8f, 0.8f, 0);      // mostasa
                Gl.glVertex3f(0.8f, 0.3f, -0.35f);      // p1
                Gl.glVertex3f(-0.8f, 0.3f, -0.35f);     // p2
                Gl.glVertex3f(-0.8f, -0.3f, -0.35f);    // p3
                Gl.glVertex3f(0.8f, -0.3f, -0.35f);     // p4
                
                // atras
                Gl.glColor3f(0.8f, 0.8f, 0);      // mostasa
                Gl.glVertex3f(0.8f, 0.3f, 0.35f);       // p5
                Gl.glVertex3f(0.8f, -0.3f, 0.35f);      // p6
                Gl.glVertex3f(-0.8f, -0.3f, 0.35f);     // p7
                Gl.glVertex3f(-0.8f, 0.3f, 0.35f);      // p8

                // piso 
                Gl.glColor3f(0.7f, 0.7f, 0);      // mostasa
                Gl.glVertex3f(0.8f, -0.3f, -0.35f);     // p4
                Gl.glVertex3f(-0.8f, -0.3f, -0.35f);    // p3
                Gl.glVertex3f(-0.8f, -0.3f, 0.35f);     // p7
                Gl.glVertex3f(0.8f, -0.3f, 0.35f);      // p6
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            // marco puerta
            Gl.glColor3f(0, 0.5f, 0.5f);      // negro
            Gl.glVertex3f(-0.45f, -0.3f, -0.35f);    // p3  -39x
            Gl.glVertex3f(-0.15f, -0.3f, -0.35f);    // p4  -99x
            Gl.glVertex3f(-0.15f, 0.15f, -0.35f);    // p4  -99x + 4y 
            Gl.glVertex3f(-0.45f, 0.15f, -0.35f);    // p3  -39x + 4y

            // puertas
            Gl.glColor3f(0.5f, 0.3f, 0);      // negro
            Gl.glVertex3f(-0.41f, -0.3f, -0.35f);    // p3  -39x
            Gl.glVertex3f(-0.19f, -0.3f, -0.35f);    // p4  -99x
            Gl.glVertex3f(-0.19f, 0.1f, -0.35f);    // p4  -99x + 4y 
            Gl.glVertex3f(-0.41f, 0.1f, -0.35f);    // p3  -39x + 4y

            // marco ventas
            Gl.glColor3f(0, 0.5f, 0.5f);      // negro
            Gl.glVertex3f(-0.05f, -0.15f, -0.35f);     // p3  con x = 0 y +2y
            Gl.glVertex3f(0.65f, -0.15f, -0.35f);     // p4  -2x
            Gl.glVertex3f(0.65f, 0.22f, -0.35f);     // p4  -2x y +47y
            Gl.glVertex3f(-0.05f, 0.22f, -0.35f);     // p3  con x = 0 y +47y

            // ventas
            Gl.glColor3f(0, 1, 1);      // negro
            Gl.glVertex3f(0.0f, -0.1f, -0.35f);     // p3  con x = 0 y +2y
            Gl.glVertex3f(0.6f, -0.1f, -0.35f);     // p4  -2x
            Gl.glVertex3f(0.6f, 0.17f, -0.35f);     // p4  -2x y +47y
            Gl.glVertex3f(0.0f, 0.17f, -0.35f);     // p3  con x = 0 y +47y
            Gl.glEnd();

             Gl.glBegin(Gl.GL_POLYGON);
                // lado izquierdo
                Gl.glColor3f(0.7f, 0.7f, 0);      // mostasa
                Gl.glVertex3f(-0.8f, -0.3f, -0.35f);    // p3
                Gl.glVertex3f(-0.8f, 0.3f, -0.35f);     // p2
                Gl.glVertex3f(-0.8f, 0.5f, 0.0f);       // p9
                Gl.glVertex3f(-0.8f, 0.3f, 0.35f);      // p8
                Gl.glVertex3f(-0.8f, -0.3f, 0.35f);     // p7  
            Gl.glEnd();

            Gl.glBegin(Gl.GL_POLYGON);
                // lado derecho
                Gl.glColor3f(0.7f, 0.7f, 0);      // mostasa
                Gl.glVertex3f(0.8f, -0.3f, -0.35f);     // p4
                Gl.glVertex3f(0.8f, -0.3f, 0.35f);      // p6
                Gl.glVertex3f(0.8f, 0.3f, 0.35f);       // p5
                Gl.glVertex3f(0.8f, 0.5f, 0.0f);        // p9  x+
                Gl.glVertex3f(0.8f, 0.3f, -0.35f);      // p1
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);
            // techo frente
            Gl.glColor3f(0, 0, 1);      // azul
            Gl.glVertex3f(0.9f, 0.25f, -0.45f);      // p1  +1x y -5y y +1z negativo 
            Gl.glVertex3f(0.9f, 0.5f, 0.0f);         // p9  +1x
            Gl.glVertex3f(-0.9f, 0.5f, 0.0f);        // p9  +1x negativo
            Gl.glVertex3f(-0.9f, 0.25f, -0.45f);     // p2  +1x y -5y negativo y +1z negativo 

            //techo detras
            Gl.glColor3f(0, 0, 1);      // azul
            Gl.glVertex3f(0.9f, 0.5f, 0.0f);         // p9  +1x
            Gl.glVertex3f(0.9f, 0.25f, 0.45f);       // p5  +1x y +1z y -5y
            Gl.glVertex3f(-0.9f, 0.25f, 0.45f);      // p8  +1x y -5y negativo y +1z 
            Gl.glVertex3f(-0.9f, 0.5f, 0.0f);        // p9  +1x negativo

            Gl.glEnd();
        }

        private int anguloX = 0, anguloY = 0, anguloZ = 0;

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glRotated(anguloX, 1, 0, 0);
            Gl.glRotated(anguloY, 0, 1, 0);
            Gl.glRotated(anguloZ, 0, 0, 1);

            Gl.glTranslated(trasX, 0, 0);
            Gl.glTranslated(0, trasY, 0);
            Gl.glTranslated(0, 0, trasZ);

            Gl.glScaled(escalarX, 1, 1);
            Gl.glScaled(1, escalarY, 1);
            Gl.glScaled(1, 1, escalarZ);
            Gl.glScaled(escalar, escalar, escalar);

            dado();
        }


        private void figuraCompuesta()
        {
            Gl.glRotatef(45, 0, 0, 1);
            Gl.glScalef(0.5f, 0.5f, 0);
            hexagono();

            //Gl.glLoadIdentity();
            Gl.glRotatef(45, 0, 0, 1);
            //Gl.glScalef(0.5f, 0.5f, 0);
            hexagono();
        }

        private void hexagono()
        {
            

            Gl.glBegin(Gl.GL_POLYGON);
            Gl.glVertex2f(1, 1);
            Gl.glVertex2f(-1, 1);
            Gl.glVertex2f(-1, -1);
            Gl.glVertex2f(1, -1);
            Gl.glEnd();
        }

        Random color = new Random();

        private void figura()
        {   
            //Gl.glLoadIdentity();
            //Gl.glPushMatrix();
            Gl.glScalef(0.5f, 0.5f, 0);
            cuadrado();
            Gl.glRotatef(45, 0, 0, 1);
            cuadrado();

            Gl.glColor3f(0, 0, 0);
            Gl.glScalef(0.6f, 0.6f, 0);
            cuadrado();
            Gl.glRotatef(45, 0, 0, 1);
            cuadrado();
            //Gl.glPopMatrix();
        }

        private void cuadradosDeColores()
        {
            int i = 0;

            while (++i <= 10)
            {
                cuadradoDeColor();
                Gl.glScalef(0.8f, 0.8f, 0);

            }
        }

        private void cuadradoDeColor()
        {
            Gl.glColor3f(color.Next(0, 10) / 10.0f, color.Next(0, 10) / 10.0f, color.Next(0, 10) / 10.0f);

            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(1, 1);
                Gl.glVertex2f(-1, 1);
                Gl.glVertex2f(-1, -1);
                Gl.glVertex2f(1, -1);
            Gl.glEnd();
        }

        private void cuadrado()
        {
            Gl.glBegin(Gl.GL_POLYGON);
                Gl.glVertex2f(1, 1);
                Gl.glVertex2f(-1, 1);
                Gl.glVertex2f(-1, -1);
                Gl.glVertex2f(1, -1);
            Gl.glEnd();
        }

        static void elipceBresenham(int rx, int ry, float posx, float posy)
        {
            int x = 0;
            int y = ry;
            int d = (int)(Math.Pow(ry, 2) + Math.Pow(rx, 2) * (-ry + 1 / 4));
            dibujar_simetria4(x, y, posx, posy);
            while (Math.Pow(rx, 2) * (y - 1 / 2) > Math.Pow(ry, 2) * (x + 1)) //Region 1
            {
                if (d < 0)
                {
                    d = d + (int)(Math.Pow(ry, 2) * (2 * x + 3));
                    x += 1;
                }
                else
                {
                    d = d + (int)(Math.Pow(ry, 2) * (2 * x + 3) + Math.Pow(rx, 2) * (-2 * y + 2));
                    x += 1; y -= 1;
                }
                dibujar_simetria4(x, y, posx, posy);
            }
            d = (int)(Math.Pow(ry, 2) * Math.Pow((x + 1 / 2), 2) + Math.Pow(rx, 2) * Math.Pow((y - 1), 2) - Math.Pow(rx, 2) * Math.Pow(ry, 2)); //REGION 2
            while (y > 0)                  //Region 2
            {
                if (d < 0)
                {
                    d = d + (int)(Math.Pow(ry, 2) * (2 * x + 2) + Math.Pow(rx, 2) * (-2 * y + 3));
                    x += 1; y -= 1;
                }
                else
                {
                    d = d + (int)(Math.Pow(rx, 2) * (-2 * y + 3));
                    y -= 1;
                }
                dibujar_simetria4(x, y, posx, posy);
            }
        }

        static void dibujar_simetria4(int x, int y, float posx1, float posy1)
        {
            int esc = 800;
            dibujar_punto(x + posx1, y + posy1, esc);
            dibujar_punto(-x + posx1, y + posy1, esc);
            dibujar_punto(x + posx1, -y + posy1, esc);
            dibujar_punto(-x + posx1, -y + posy1, esc);
        }
        static void dibujar_punto(float x, float y, int esc)
        {
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f((float)x / (float)esc, (float)y / (float)esc);
            Gl.glEnd();
        }





        /***********************************************************
         * para hacer girar el dado
         * *********************************************************/
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            anguloX = trackBar1.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            anguloY = trackBar2.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            anguloZ = trackBar3.Value;
            simpleOpenGlControl1.Refresh();
        }


        private int escalarX = 1, escalarY = 1, escalarZ = 1, escalar = 1;

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            escalar = trackBar4.Value;
            simpleOpenGlControl1.Refresh();
        }


        private int trasX = 0, trasY = 0, trasZ = 0;
        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            trasX = trackBar5.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            trasY = trackBar6.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            trasZ = trackBar7.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            escalarX = trackBar8.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            escalarZ = trackBar10.Value;
            simpleOpenGlControl1.Refresh();
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            escalarY = trackBar9.Value;
            simpleOpenGlControl1.Refresh();
        }
    }
}


      
                /*
                Gl.glColor3f(1, 0, 0);
                elipceBresenham(100, 37, 120, 250);
                elipceBresenham(100, 37, -120, 250);
                elipceBresenham(100, 37, -300, 200);
                elipceBresenham(100, 37, 300, 200);
          
 

                elipceBresenham(400, 150, 0, 0);

      */
                /**
                            Gl.glColor3f(0, 1, 0);
                            elipceBresenham(500, 250, 0, 0);
                            elipceBresenham(250, 500, 0, 0);
                            //elipceBresenham(500, 250, 0, 0);
                            Gl.glColor3f(0, 0, 1);
                            elipceBresenham(75, 250, 0, 0);
                            elipceBresenham(250, 75, 0, 0);
                            //elipceBresenham(250, 500, 0, 0);
                            //elipceBresenham(500, 250, 0, 0);
                            //elipceBresenham(250, 500, 0, 0);
                            //elipceBresenham(500, 250, 0, 0);
                            //elipceBresenham(250, 500, 0, 0);          
                 * 
                 * */
                //Gl.glColor3f(0, 1, 0);
                //Gl.glBegin(Gl.GL_LINES);
                //Gl.glVertex2f(-250 / 1000.0f, 250 / 1000.0f);
                //Gl.glVertex2f(-50 / 1000.0f, 200 / 1000.0f);
                //Gl.glVertex2f(50 / 1000.0f, 200 / 1000.0f);
                //Gl.glVertex2f(250 / 1000.0f, 250 / 1000.0f);
                //Gl.glEnd();


                //elipceBresenham(350, 500, 0, 0);

                //elipceBresenham(75, 100, 100, 0);
                //elipceBresenham(75, 100, -100, 0);

                //Gl.glBegin(Gl.GL_LINE_STRIP);
                //Gl.glVertex2f(-250 / 1000.0f, -250 / 1000.0f);
                //Gl.glVertex2f(-150 / 1000.0f, -200 / 1000.0f);
                //Gl.glVertex2f(150 / 1000.0f, -200 / 1000.0f);
                //Gl.glVertex2f(250 / 1000.0f, -250 / 1000.0f);
                //Gl.glEnd();




                /**
                 * rellenos
                 */


                //Gl.glLoadIdentity();

                //Gl.glTranslatef(-0.5f, 0.5f, 0);
                //Gl.glScalef(0.5f, 0.5f, 0);
                //cuadradosDeColores();

                //Gl.glLoadIdentity();

                //Gl.glTranslatef(0.5f, 0.5f, 0);
                //Gl.glScalef(0.5f, 0.5f, 0);
                //cuadradosDeColores();

                //Gl.glLoadIdentity();

                //Gl.glTranslatef(-0.5f, -0.5f, 0);
                //Gl.glScalef(-0.5f, 0.5f, 0);
                //cuadradosDeColores();

                //Gl.glLoadIdentity();

                //Gl.glTranslatef(0.5f, -0.5f, 0);
                //Gl.glScalef(0.5f, 0.5f, 0);
                //cuadradosDeColores();



                //Gl.glLoadIdentity();
                //Gl.glColor3f(1, 0, 0);
                //figura();
                //Gl.glLoadIdentity();            
                //Gl.glColor3f(1, 0, 0);
                //Gl.glTranslatef(0.3f, 0.3f, 0);
                //Gl.glScalef(0.6f, 0.6f, 0);
                //figura();

                //Gl.glLoadIdentity();

                //Gl.glColor3f(1, 0, 0);
                //Gl.glTranslatef(0.6f, 0.6f, 0);
                //Gl.glScalef(0.6f, 0.6f, 0);
                //figura();

                //Gl.glLoadIdentity();
                //Gl.glColor3f(1, 0, 0);
                //Gl.glTranslatef(-0.5f, 0.5f, 0);
                //Gl.glScalef(0.5f, 0.5f, 0);
                //figura();
                //Gl.glLoadIdentity();
                //Gl.glTranslatef(-0.5f, 0f, 0);
                //figura();

                //Gl.glTranslatef(0.5f, 0f, 0);
                //figura();



                ///////       otra figura 
                //Gl.glLoadIdentity();
                //Gl.glColor3f(0, 1, 0);
                //figuraCompuesta();

                //Gl.glLoadIdentity();
                //Gl.glColor3f(0, 1, 1);
                //Gl.glScalef(0.75f, 0.75f, 0);
                //Gl.glRotatef(22, 0, 0, 1);
                //figuraCompuesta();

                //Gl.glLoadIdentity();
                //Gl.glColor3f(0, 0, 1);
                //Gl.glScalef(0.60f, 0.60f, 0);
                //figuraCompuesta();

                //Gl.glLoadIdentity();
                //Gl.glColor3f(1, 0, 0);
                //Gl.glScalef(0.45f, 0.45f, 0);
                //Gl.glRotatef(22, 0, 0, 1);
                //figuraCompuesta();

                //Gl.glLoadIdentity();
                //Gl.glColor3f(1, 1, 0);
                //Gl.glScalef(0.35f, 0.35f, 0);
                //figuraCompuesta();

                //Gl.glLoadIdentity();
                //Gl.glColor3f(0, 0, 0);
                //Gl.glScalef(0.3f, 0.3f, 0);
                //Gl.glRotatef(22, 0, 0, 1);
                //figuraCompuesta();