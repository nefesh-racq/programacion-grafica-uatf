using System;
using System.Windows.Forms;

using Tao.OpenGl;

namespace Examen2p1_resuelto
{
    public partial class Form1 : Form
    {
        private Timer ciclos = new Timer();
        private Timer pausa = new Timer();
        private int angulos = 0;
        private int inc = 1;

        public Form1()
        {
            InitializeComponent();

            ciclos.Interval = 10;
            ciclos.Enabled = true;
            ciclos.Tick += new EventHandler(Ciclo_timer);

            pausa.Interval = 1000;
            pausa.Tick += new EventHandler(Pausa_timer);

            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(0.5f, 0.1f, 0, 1);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glLoadIdentity();

            Gl.glRotatef(angulos, 0, 0, 1);
            Figura();
        }

        private void Figura()
        {
            // linea
            Gl.glLineWidth(10);
            Gl.glColor3f(1, 1, 0);

            Gl.glBegin(Gl.GL_LINES);
                Gl.glVertex2f(0, 0);
                Gl.glVertex2f(0.9f, 0);
            Gl.glEnd();

            // circunferencia
            float angulo, x, y;

            Gl.glColor3f(0, 1, 0);
            Gl.glBegin(Gl.GL_POLYGON);
            for (int i = 0; i < 360; i++)
            {
                angulo = i * (float)Math.PI / 180.0f;
                x = (float)Math.Cos(angulo) * 0.1f;
                y = (float)Math.Sin(angulo) * 0.1f;

                Gl.glVertex2f(x + 0.9f, y + 0);
            }
            Gl.glEnd();
        }

        // mueve la figura de lado a lado
        private void Ciclo_timer(object sender, EventArgs e)
        {
            if (angulos > 180 || angulos < 0)
            {
                inc = -inc;
                ciclos.Enabled = false;
                pausa.Enabled = true;
            }

            angulos += inc;
            simpleOpenGlControl1.Refresh();
        }

        // hace la pausa en los extremos
        private void Pausa_timer(object sender, EventArgs e)
        {
            ciclos.Enabled = true;
            pausa.Enabled = false;
        }

    }
}
