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

namespace tarea1_preg2
{
    public partial class Form1 : Form
    {
        private List<Punto> listaPuntos = new List<Punto>();
        private int escala = 100;

        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            //Gl.glClearColor(0.7f, 0.2f, 0.7f, 0.0f);
            Gl.glClearColor(0f, 0f, 0f, 0.0f);
            CargarCamino();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            //regilla();


            foreach (Punto row in listaPuntos)
            {
                row.DibujarPunto(100);
            }

            Gl.glColor3f(listaPuntos[0].color.Rojo, listaPuntos[0].color.Verde, listaPuntos[0].color.Azul);
            DDA(listaPuntos[0].X, listaPuntos[0].Y, listaPuntos[1].X, listaPuntos[1].Y);

            Gl.glColor3f(listaPuntos[1].color.Rojo, listaPuntos[1].color.Verde, listaPuntos[1].color.Azul);
            DDA(listaPuntos[1].X, listaPuntos[1].Y, listaPuntos[2].X, listaPuntos[2].Y);
            
            Gl.glColor3f(listaPuntos[2].color.Rojo, listaPuntos[2].color.Verde, listaPuntos[2].color.Azul);
            DDA(listaPuntos[2].X, listaPuntos[2].Y, listaPuntos[3].X, listaPuntos[3].Y);
            
            Gl.glColor3f(listaPuntos[3].color.Rojo, listaPuntos[3].color.Verde, listaPuntos[3].color.Azul);
            DDA(listaPuntos[3].X, listaPuntos[3].Y, listaPuntos[4].X, listaPuntos[4].Y);
            
            Gl.glColor3f(listaPuntos[4].color.Rojo, listaPuntos[4].color.Verde, listaPuntos[4].color.Azul);
            DDA(listaPuntos[4].X, listaPuntos[4].Y, listaPuntos[0].X, listaPuntos[0].Y);
        }

        private void regilla()
        {
            Gl.glColor3f(1, 1, 1);
            Gl.glPointSize(1);
            Gl.glBegin(Gl.GL_POINTS);
            for (float i = -1; i < 1; i += 0.01f)
            {
                for (float j = -1; j < 1; j += 0.1f)
                {
                    Gl.glVertex2f(i, j);
                    Gl.glVertex2f(j, i);
                }
            }
            Gl.glEnd();

        }

        public void CargarCamino()
        {
            // primero limpiamos la lista si exite alguna
            listaPuntos = new List<Punto>();
            //linea.listaRuta = new List<Punto>();

            var aleatorio = new Random();
            int j = -1;

            Color[] colores =
            {
                new Color(1, 1, 0),
                new Color(1, 0, 1),
                new Color(0, 1, 1),
                new Color(0, 0, 1),
                new Color(0, 1, 0)
            };

            while (++j < 5)
            {
                listaPuntos.Add(new Punto(aleatorio.Next(-escala, escala),
                    aleatorio.Next(-escala, escala),
                    colores[j]
                    ));

                //listaPuntos[j].DibujarPunto();
            }
        }


        public void DDA(float x0, float y0, float x1, float y1)
        {
            float dx = (x1 - x0);
            float dy = (y1 - y0);

            float pasos = (Math.Abs(dx) > Math.Abs(dy)) ? Math.Abs(dx) : Math.Abs(dy);
            float incX = dx / pasos;
            float incY = dy / pasos;

            float x = x0;
            float y = y0;

            bool cargar = true;

            Gl.glPointSize(1);
            Gl.glBegin(Gl.GL_POINTS);
            for (int i = 0; i < pasos; i++)
            {
                Gl.glVertex2f(x/escala, y/escala); 
                x += incX;
                y += incY;
            }

            Gl.glEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarCamino();

            simpleOpenGlControl1.Refresh();
        }

    }
}
