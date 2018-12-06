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

namespace examen_resuelto_p1
{
    public partial class Form1 : Form
    {
        private float anglez;           // variable para hacer girar las cruces
        private float coorx, coory;     // coordenadas para la traslacion de la figur
        private float incx, incy;       // incrementos para el movimiento
        private float tam;              // tamaño de la figura

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            // iniciamos los datos de las variables
            anglez = 0;
            coorx = coory = 0;
            incx = 0.015f;       // los incrementos son diferentes para que se mueva de forma inclinada y pueda chocar a los costados y no a la esquina
            incy = 0.023f;

            tam = 0.2f;         // en este caso no debe ser nayor a '1', por que se trabaja con la escala -1 a 1
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glTranslatef(coorx, coory, 0.0f);    // trasladamos en las coordenadas 'x' e 'y'
            figure();
        }

        /*
         * dibujamos las cruces con lineas
         * */
        private void figure()
        {
            Gl.glPushMatrix();
                Gl.glColor3f(1.0f, 0.0f, 0.0f);
                Gl.glRotatef(anglez, 0.0f, 0.0f, 1.0f);  // rotamos en el eje z
                Gl.glLineWidth(8);      // hacemos la linea mas gruesa
                Gl.glBegin(Gl.GL_LINES);
                    // lines horizontal
                    Gl.glVertex2f(tam, 0.0f);
                    Gl.glVertex2f(-tam, 0.0f);

                    // linea vertical
                    Gl.glVertex2f(0.0f, tam);
                    Gl.glVertex2f(0.0f, -tam);
                Gl.glEnd();
            Gl.glPopMatrix();

            Gl.glPushMatrix();
                Gl.glColor3f(0.0f, 1.0f, 0.0f);
                Gl.glRotatef(-anglez, 0.0f, 0.0f, 1.0f);  // rotamos en el eje z, pero inverso a lo normal
                Gl.glLineWidth(8);      // hacemos la linea mas gruesa
                Gl.glBegin(Gl.GL_LINES);
                    // lines horizontal
                    Gl.glVertex2f(tam, 0.0f);
                    Gl.glVertex2f(-tam, 0.0f);

                    // linea vertical
                    Gl.glVertex2f(0.0f, tam);
                    Gl.glVertex2f(0.0f, -tam);
                Gl.glEnd();
            Gl.glPopMatrix();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // incrementamos para el giro de la figura
            anglez += 5.0f;
            
            if (anglez >= 360)
                anglez = 0;

            // incrementos para el movimiento de la figura
            coorx += incx;
            coory += incy;

            // cada ves que la coordenada se pase del limite cambiamos los incrementos
            // es (1 - tam)  para controlar la colision del borde del objeto
            if (coorx <= -(1 - tam) || coorx >= (1 - tam))
                incx = -incx;

            if (coory <= -(1 - tam) || coory >= (1 - tam))
                incy = -incy;

            simpleOpenGlControl1.Refresh();
        }

    }
}
