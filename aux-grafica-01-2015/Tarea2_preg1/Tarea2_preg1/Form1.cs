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

namespace Tarea2_preg1
{
    public partial class Form1 : Form
    {
        private List<Circulo> _circulos = new List<Circulo>();
        private List<Circulo> _circulos1 = new List<Circulo>();
        private List<Circulo> _circulos2 = new List<Circulo>();


        public Form1()
        {
            InitializeComponent();

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 0, 1, 1);



            _circulos.Add(new Circulo(new Punto(x, y),
                          new Color(1, 0, 0),
                          0.1f
                          ) );

            _circulos.Add(new Circulo(new Punto(x, y),
                          new Color(1, 1, 0),
                          0.1f
                          ));

            _circulos.Add(new Circulo(new Punto(x, y),
                          new Color(1, 0.5f, 0),
                          0.1f
                          ));


            _circulos1.Add(new Circulo(new Punto(x, y),
                          new Color(1, 0.5f, 0.5f),
                          0.1f
                          ));

            _circulos1.Add(new Circulo(new Punto(x, y),
                          new Color(0.5f, 0.5f, 1),
                          0.1f
                          ));

            _circulos1.Add(new Circulo(new Punto(x, y),
                          new Color(0.5f, 0.5f, 0.5f),
                          0.1f
                          ));

            _circulos2.Add(new Circulo(new Punto(x, y),
                          new Color(0.8f, 0, 0.8f),
                          0.1f
                          ));
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            float angulo;
            float x, y;

            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_POINTS);

            for (int i = 0; i < 360; i++)
            {
                angulo = i * (float)Math.PI / 180.0f;
                x = (float)Math.Cos(angulo) * 0.7f;
                y = (float)Math.Sin(angulo) * 0.7f;

                Gl.glVertex2f((x), (y));
            }

            Gl.glEnd();


            Gl.glColor3f(1, 1, 1);
            Gl.glBegin(Gl.GL_POINTS);

            for (int i = 0; i < 360; i++)
            {
                angulo = i * (float)Math.PI / 180.0f;
                x = (float)Math.Cos(angulo) * 0.5f;
                y = (float)Math.Sin(angulo) * 0.5f;

                Gl.glVertex2f((x), (y));
            }

            Gl.glEnd();

            foreach (Circulo row in _circulos)
            {
                row.Dibujar();
            }

            foreach (Circulo row in _circulos1)
            {
                row.Dibujar();
            }

            foreach (Circulo row in _circulos2)
            {
                row.Dibujar();
            }
        }


        private Random al = new Random();

        private void simpleOpenGlControl1_MouseClick(object sender, MouseEventArgs e)
        {
            float alto = simpleOpenGlControl1.Height / 2.0f;
            float ancho = simpleOpenGlControl1.Width / 2.0f;

            //float x = (e.X - ancho) / ancho;
            //float y = (e.Y - alto) / -alto;


            _circulos.Add(new Circulo(new Punto(0, 0),
                                      new Color(al.Next(0, 10) / 10.0f, al.Next(0, 10) / 10.0f, al.Next(0, 10) / 10.0f),
                                      0.1f
                                      )
                         );

            simpleOpenGlControl1.Refresh();
      }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (_circulos.Count > 0)
            {
                _circulos.Clear();
                simpleOpenGlControl1.Refresh();
            }
        }


        private float x, y, angulo;
        private int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 360)
                i = 0;

            i += 5;

            angulo = i * (float)Math.PI / 180.0f;
            x = (float)Math.Cos(angulo) * 0.7f;
            y = (float)Math.Sin(angulo) * 0.7f;

            _circulos[0].punto.x = x;
            _circulos[0].punto.y = y;


            int j = i + 20;

            angulo = j * (float)Math.PI / 180.0f;
            x = (float)Math.Cos(angulo) * 0.7f;
            y = (float)Math.Sin(angulo) * 0.7f;

            _circulos[1].punto.x = x;
            _circulos[1].punto.y = y;


            float k = j + 20;

            angulo = k * (float)Math.PI / 180.0f;
            x = (float)Math.Cos(angulo) * 0.7f;
            y = (float)Math.Sin(angulo) * 0.7f;

            _circulos[2].punto.x = x;
            _circulos[2].punto.y = y;

            /*
             * circulos del medio
             * */


            angulo = i * (float)Math.PI / 180.0f;
            y = (float)Math.Cos(angulo) * 0.5f;
            x = (float)Math.Sin(angulo) * 0.5f;

            _circulos1[0].punto.x = x;
            _circulos1[0].punto.y = y;
           
            j = i + 30;

            angulo = j * (float)Math.PI / 180.0f;
            y = (float)Math.Cos(angulo) * 0.5f;
            x = (float)Math.Sin(angulo) * 0.5f;

            _circulos1[1].punto.x = x;
            _circulos1[1].punto.y = y;


            k = j + 30;

            angulo = k * (float)Math.PI / 180.0f;
            y = (float)Math.Cos(angulo) * 0.5f;
            x = (float)Math.Sin(angulo) * 0.5f;

            _circulos1[2].punto.x = x;
            _circulos1[2].punto.y = y;


            simpleOpenGlControl1.Refresh();
        }

    }
}
