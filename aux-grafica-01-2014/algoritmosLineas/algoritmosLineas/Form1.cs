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

namespace algoritmosLineas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /****/
            simpleOpenGlControl1.InitializeContexts();
            Gl.glClearColor(1, 1, 1, 0);
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            rectaEcuacion(0, 0, 100, 0);
            rectaEcuacion(0, 0, 100, 100);
            rectaEcuacion(0, 0, 10, 100);

            rectaDDA(0, 0, -10, -40);
        }

        private int escala = 100;

        private void rectaEcuacion(int x0, int y0, int x1, int y1) {
            int dx, dy, x;
            float m, y, b;

            dx = x1 - x0;
            dy = y1 - y0;
            m = (float)dy / dx;
            b = y0 - m * x0;

           // y = y0;
            for (x = x0; x < x1; x++) { 
                y = m * x + b;
                setPixel(x, (int)Math.Round(y), escala);             
            }
        }

        private void rectaDDA(int x0, int y0, int x1, int y1) {
            int dx, dy, pasos;
            float incX, incY, x, y;

            dx = x1 - x0;
            dy = y1 - y0;
            pasos = (Math.Abs(dx) > Math.Abs(dy)) ? Math.Abs(dx) : Math.Abs(dy);
            incX = (float)dx / pasos;
            incY = (float)dy / pasos;

            x = x0;
            y = y0;
            setPixel(x, y, 100);

            for (int p = 0; p < pasos; p++) {
                x += incX;
                y += incY;
                setPixel(x, y, 100);
            }
        }

        private void rectaBresenham() { }

        private void setPixel(float x, float y, int escala) {
            Gl.glColor3f(0, 0, 1);
            Gl.glPointSize(2);
            Gl.glBegin(Gl.GL_POINTS);
                Gl.glVertex2f((float)x / escala, (float)y / escala);
            Gl.glEnd();
        }
    }
}
