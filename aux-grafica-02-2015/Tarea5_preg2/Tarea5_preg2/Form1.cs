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
using Tao.FreeGlut;

namespace Tarea5_preg2
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        private float angle = 0;
        private Esfera esfera;
        private Arbol arbol;
        private List<Nieve> nieve;
        private Casa casa;
        private bool v = false;
        private Fondo fondo;

        public Form1()
        {
            InitializeComponent();
            simpleOpenGlControl1.InitializeContexts();

            Gl.glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
            //Gl.glClearColor(0.6f, 1.0f, 0.6f, 1.0f);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, 1.0f, 1.0f, 500.0f);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Glut.glutInit();
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            //Gl.glEnable(Gl.GL_TEXTURE_2D);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_BLEND);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);

            t.Tick += new EventHandler(cicle);
            t.Enabled = true;
            t.Interval = 100;

            esfera = new Esfera();
            arbol = new Arbol();
            Random r = new Random();
            nieve = new List<Nieve>();
            for (int i = 0; i < 500; i++)
                nieve.Add(new Nieve(r));
            casa = new Casa();
            fondo = new Fondo();
        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            material();
            Gl.glTranslatef(0.0f, 0.0f, -11.0f);
            Gl.glRotatef(30, 0.0f, 1.0f, 0.0f);
            fondo.dibujar();
            Gl.glRotatef(angle, .0f, 1.0f, 0.0f);

            foreach (Nieve l in nieve)
            {
                l.dibujar();
            }

            Gl.glPushMatrix();
            Gl.glTranslatef(0.0f, 0.7f, 0.0f);
            arbol.dibujar();
            casa.dibujar();
            Gl.glPopMatrix();
            esfera.dibujar();
        }


        private void cicle(Object sender, EventArgs e)
        {
            if (v)
            if (++angle > 360)
                angle = 0;

            foreach (Nieve l in nieve)
            {
                l.caer();
            }

            simpleOpenGlControl1.Refresh();
        }

        private void material()
        {
            float[] mat_specular = {1.0f, 1.0f, 1.0f, 1.0f};
            float[] mat_shininess = {50.0f};
            float[] light_position = {0.0f, 0.0f, 0.0f, 1.0f};
            Gl.glShadeModel(Gl.GL_SMOOTH);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SPECULAR, mat_specular);
            Gl.glMaterialfv(Gl.GL_FRONT, Gl.GL_SHININESS, mat_shininess);
            //Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light_position);
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            v = !v;
        }

    }
}
